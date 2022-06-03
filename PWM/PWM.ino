String data,x;
char dl;
int Q1 = 9;
int Q2 = 10;
int Q3 = 11;
int RELE = 13;
int TIME_PWM;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(RELE,OUTPUT);
  pinMode(Q1,OUTPUT);
}

void loop() {
  
  if(Serial.available()){
    data = Serial.readString();
    dl = data.charAt(0);

    switch (dl)
    {
      case '1':
      digitalWrite(RELE,HIGH);
      break;

      case'0':
      digitalWrite(RELE,LOW);
      break;

      case 'T':
      x = data.substring(1);
      TIME_PWM = x.toInt();
      analogWrite(Q1,100);
      analogWrite(Q2,100);
      analogWrite(Q3,100);
      delay(100);
      analogWrite(Q1,0);
      analogWrite(Q2,0);
      analogWrite(Q3,0);
      break;

      case 'A':
      x = data.substring(1);
      
      break;
      }
      
    }

}
