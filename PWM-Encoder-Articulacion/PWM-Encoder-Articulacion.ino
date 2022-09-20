#include <AccelStepper.h> 

String data;
char x,y;
char dl;

int Q1M = 23;
int Q1D = 22;

int Q2M = 25;
int Q2D = 24;

int Q3M = 27;
int Q3D = 26;

int SW1= 7;
int SW2= 6;
int SW3= 5;
int SW4= 4;

int conf0 = 3;
int conf1 = 2;

int CONF = 0;

int RELE = 28;
int TIME_PWM;

const int CLOCK_PIN = 52; // Blue Pin 5
const int DATA_PIN = 50; // Green Pin 6

const int CS_PIN0 = 48; // Yellow Pin 7
const int CS_PIN1 = 47;
const int CS_PIN2 = 46;

const int BIT_COUNT = 12; // 12 Bit Mode



const byte interruptPin1 = 19; //pin for the microswitch using attachInterrupt(); 
const byte interruptPin2 = 20; //pin for the microswitch using attachInterrupt(); 
const byte interruptPin3 = 21; //pin for the microswitch using attachInterrupt(); 

// AccelStepper Setup
AccelStepper Q1(1, Q1M, Q1D);   // 1 = Easy Driver interface
                                  // UNO Pin 2 connected to STEP pin of Easy Driver
                                  // UNO Pin 3 connected to DIR pin of Easy Driver
                                  
AccelStepper Q2(1, Q2M, Q2D);   // 1 = Easy Driver interface
                                  // UNO Pin 5 connected to STEP pin of Easy Driver
                                  // UNO Pin 6 connected to DIR pin of Easy Driver
AccelStepper Q3(1, Q3M, Q3D);   // 1 = Easy Driver interface

// Stepper Travel Variables
long TravelQ1;  // Used to store the X value entered in the Serial Monitor
long TravelQ2;  // Used to store the Z value entered in the Serial Monitor
long TravelQ3;
int move_finished=1;  // Used to check if move is completed


void setup() {
  
  pinMode(interruptPin1, INPUT_PULLUP); // internal pullup resistor (debouncing)
  attachInterrupt(digitalPinToInterrupt(interruptPin1), stopMotor1, FALLING); 
  pinMode(interruptPin2, INPUT_PULLUP); // internal pullup resistor (debouncing)
  attachInterrupt(digitalPinToInterrupt(interruptPin2), stopMotor2, FALLING); 
   pinMode(interruptPin3, INPUT_PULLUP); // internal pullup resistor (debouncing)
  attachInterrupt(digitalPinToInterrupt(interruptPin3), stopMotor3, FALLING); 
  
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(RELE,OUTPUT);
  pinMode(SW1,INPUT);
  pinMode(SW2,INPUT);
  pinMode(SW3,INPUT);
  pinMode(SW4,INPUT); 

  pinMode(conf0,INPUT);
  pinMode(conf1,INPUT); 
  //setup our pins
  pinMode(DATA_PIN, INPUT);
  pinMode(CLOCK_PIN, OUTPUT);
  pinMode(CS_PIN0, OUTPUT);
  pinMode(CS_PIN1, OUTPUT);
  pinMode(CS_PIN2, OUTPUT);
  //give some default values
  
  digitalWrite(CLOCK_PIN, HIGH);
  digitalWrite(CS_PIN0, HIGH);
  digitalWrite(CS_PIN1, HIGH);
  digitalWrite(CS_PIN0, HIGH);
  digitalWrite(RELE, HIGH);

  Q1.setMaxSpeed(250.0);      // Set Max Speed of X axis
  Q1.setAcceleration(300.0);  // Acceleration of X axis

  Q2.setMaxSpeed(250.0);      // Set Max Speed of Y axis slower for rotation
 Q2.setAcceleration(300.0);  // Acceleration of Y axis
 
 Q3.setMaxSpeed(250.0);      // Set Max Speed of Y axis slower for rotation
 Q3.setAcceleration(300.0);  // Acceleration of Y axis
 
}

void loop() {
   move_finished=0;
  int v1 = digitalRead(SW1);
      int v2 = digitalRead(SW2);
      int v3 = digitalRead(SW3);
      int v4 = digitalRead(SW4);
      String enviaDefault =String(CONF)+'*'+String(0)+'*'+String(0)+'*'+String(0)+'*'+'F';  
      String envia= enviaDefault;
  if(Serial.available()){
    data = Serial.readString();
    dl = data.charAt(0);

    switch (dl)
    {
      case '1':
        if( v1 == HIGH && v2 == HIGH && v3 == HIGH && v4 == HIGH )
        {
          digitalWrite(RELE,LOW);
          CONF = readConfig();
          
          envia= String(CONF)+'*'+String(0)+'*'+String(0)+'*'+String(0)+'*'+'F'; 
          Serial.println(envia);
          
        }
      break;

      case '0':
      if( v1 == HIGH && v2 == HIGH && v3 == HIGH && v4 == HIGH )
        {
        digitalWrite(RELE,HIGH);
        envia= String(CONF)+'*'+String(0)+'*'+String(0)+'*'+String(0)+'*'+'F'; 
        Serial.println(envia);
        }
       break;

      case 'T':
      
      x = data.charAt(1);
      readEncoder();
      break;

      case 'A':
      x = data.charAt(1);
      y = data.charAt(2);
      switch (x){
        case '1': 
          if(y == 'M'){
            TravelQ1= -1;
            TravelQ2=0;
            TravelQ3=0;
            Q1.move(TravelQ1);  // Set new move position for X Stepper
            if ((Q1.distanceToGo() != 0)){
                Q1.run();
              }
            if ((move_finished == 0) && (Q1.distanceToGo() == 0)) {
              move_finished=1;  // Reset move variable
              
              envia= enviaDefault; 
              Serial.println(envia);
            }  
            }
           if(y == 'P'){
            TravelQ1= 1;
            TravelQ2=0;
            TravelQ3=0;
            Q1.move(TravelQ1);  // Set new move position for X Stepper
            if ((Q1.distanceToGo() != 0)){
                Q1.run();
              }
            if ((move_finished == 0) && (Q1.distanceToGo() == 0)) {
              move_finished=1;  // Reset move variable
              
              envia= enviaDefault; 
              Serial.println(envia);
            }
            }
         break;
        case '2':
        
          if(y == 'M'){
            TravelQ2= -50;
            TravelQ1=0;
            TravelQ3=0;
            Q2.move(TravelQ2);  // Set new move position for Z Stepper
            while(Q2.distanceToGo() != 0){
              Q2.run();
            }
            if ((move_finished == 0) && (Q2.distanceToGo() == 0)) {
              
              move_finished=1;  // Reset move variable
    
              envia= enviaDefault; 
              Serial.println(envia);
            }
            }
           if(y == 'P'){
            TravelQ2= 50;
            TravelQ1=0;
            TravelQ3=0;
            Q2.move(TravelQ2);  // Set new move position for Z Stepper
            while(Q2.distanceToGo() != 0){
              Q2.run();
            }
            if ((move_finished == 0) && (Q2.distanceToGo() == 0)) {
              
              move_finished=1;  // Reset move variable
              
              envia= enviaDefault; 
              Serial.println(envia);
              }
            }
         break;
        case '3':
        
          if(y == 'M'){
            TravelQ3= -2;
            TravelQ2=0;
            TravelQ1=0;
            Q3.move(TravelQ3);
            while(Q3.distanceToGo() != 0){
              Q3.run();
            }
            if ((move_finished == 0) && (Q3.distanceToGo() == 0)) {
              
              move_finished=1;  // Reset move variable
              
              envia= enviaDefault; 
              Serial.println(envia);
            }
            }
           if(y == 'P'){
            TravelQ3= 2;
            TravelQ2=0;
            TravelQ1=0;
            Q3.move(TravelQ3);
            while(Q3.distanceToGo() != 0){
              Q3.run();
            }
            if ((move_finished == 0) && (Q3.distanceToGo() == 0)) {
              
              move_finished=1;  // Reset move variable
              envia= enviaDefault; 
              Serial.println(envia);
            }
            }
         break;
        }
      break;
      }
      
    }

}

void readEncoder()
{
  float reading = readPosition(CS_PIN0);
  float reading2 = readPosition(CS_PIN1);
  float reading3 = readPosition(CS_PIN2);
  if (reading >= -0.5)
  {
    //Serial.print("Reading: ");
    Serial.println(String(CONF)+'*'+String(reading)+'*'+String(reading2)+'*'+String(reading3)+'*'+'N');
  }
  delay(1000);
  
  }
float readPosition(const int css_pin)
{
  // Read the same position data twice to check for errors
  unsigned long sample1 = shiftIn(DATA_PIN, CLOCK_PIN,  css_pin, BIT_COUNT);
  unsigned long sample2 = shiftIn(DATA_PIN, CLOCK_PIN,  css_pin, BIT_COUNT);
  delayMicroseconds(20); // Clock must be high for 20 microseconds before a new sample can be taken
  if (sample1 != sample2) return -1.0;
  return ((sample1 & 0x0FFF) * 360UL) / 4096.0;
}

//read in a byte of data from the digital input of the board.
unsigned long shiftIn(const int data_pin, const int clock_pin, const int cs_pin, const int bit_count)
{
  unsigned long data = 0;

  digitalWrite(cs_pin, LOW);
  for (int i = 0; i < bit_count; i++)
  {
    data <<= 1;
    digitalWrite(clock_pin, LOW);
    delayMicroseconds(1);
    digitalWrite(clock_pin, HIGH);
    delayMicroseconds(1);

    data |= digitalRead(data_pin);
  }
  digitalWrite(cs_pin, HIGH);
  return data;
}  

int readConfig()
{
  int c1 = digitalRead(conf0);
  int c2 = digitalRead(conf1);

  if(c1 == LOW && c2 == LOW)
  {
    CONF = 0;
    return CONF;    
    }
   if(c1 == HIGH && c2 == LOW)
  {
    CONF = 1;
    return CONF;    
    }
   if(c1 == LOW && c2 == HIGH)
  {
    CONF = 2;
    return CONF;    
    }  
  }






  





void stopMotor1()//function activated by the pressed microswitch
{
  //Stop motor, disable outputs; here we should also reset the numbers if there are any  
      Q1.setCurrentPosition(0); // reset position
      Q1.stop(); //stop motor
      Q1.disableOutputs(); //disable power
}
void stopMotor2()//function activated by the pressed microswitch
{
  //Stop motor, disable outputs; here we should also reset the numbers if there are any  
      Q2.setCurrentPosition(0); // reset position
      Q2.stop(); //stop motor
      Q2.disableOutputs(); //disable power
}
void stopMotor3()//function activated by the pressed microswitch
{
  //Stop motor, disable outputs; here we should also reset the numbers if there are any  
      Q3.setCurrentPosition(0); // reset position
      Q3.stop(); //stop motor
      Q3.disableOutputs(); //disable power
}
void verificaMotor(){
  if ((Q1.distanceToGo() != 0) || (Q2.distanceToGo() !=0) || (Q3.distanceToGo() !=0)) {
    
    Q1.run();  // Move Stepper X into position
    Q2.run();  // Move Stepper Z into position
    Q3.run();  // Move Stepper Z into position
    
  }

// If move is completed display message on Serial Monitor
  if ((move_finished == 0) && (Q1.distanceToGo() == 0) && (Q2.distanceToGo() == 0) && (Q3.distanceToGo() == 0)) {
    // Get ready for new Serial monitor values
    move_finished=1;  // Reset move variable
  }
  }



  String travel[3];
  String sectionData;
  int a;
  int stringData;

  
  for(a = 0; a <data.length()-1; a++)
  {
    travel[a] = getData(data,' ',a);
   }
String getData(String data, char delimiter, int sequence)
{
  stringData = 0;
  sectionData = "";

  for (int i = 0; i < data.length() - 1; i++)
  {

    if (data[i] == delimiter)
    {
      stringData++;
    }

    else if (stringData == sequence)
    {
      sectionData.concat(data[i]);
    }

    else if (stringData > sequence)
    {
      return sectionData;
      break;
    }
  }
  return sectionData;
}

  

    
