from ctypes.wintypes import LPWIN32_FIND_DATAA
from pickle import LONG1
from numpy import *
import math




def function_doSeguimiento(configuracion, archivo):

    x = []
    y = []
    z = []

    txx =  empty((1,3))    

    with open ("cuadrado.txt") as file_object:
        for line in file_object.readlines():
            line = line.split()
            txx  = append(txx, array[float(line[0]), float(line[1]), float(line[2])],axis = 0)
            x.append(float(line[0]))
            y.append(float(line[1]))
            z.append(float(line[2]))

      
        
    [tam1, tam2]=[len(x),3]
    ajuste1=zeros(tam1,tam2)
    ajuste1[:,2]=-2
    ajuste2=zeros(tam1,tam2)
    ajuste2[:,1]=4
    ajuste3=zeros(tam1,tam2)
    ajuste3[:,3]=6

    txx_aj=txx+ajuste1+ajuste2+ajuste3

    '''
    path_p_plot=txx_aj; 

    path=txx_aj

    metodo=4

    q = mappol(path,configuracion,estructura) 
    '''

def function_CinematicaInversa(configuracion, x, y, z):
    L1 = 3
    L2 = 2 
    L3 = 3 
    h0 = 4 
    h1 = 2
    h2 = 2 
    h3 = 2 

    if configuracion == 1:
        return function_cilindrica(L2,L3,h0,h1,h2,x,y,z)
    elif configuracion ==2:
        return function_angular(L1,L2,L3,h0,h1,x,y,z)
    elif configuracion == 3:
        return function_esferica(L1,L2,L3,h0,h1,x,y,z)
    else:
        return None

def function_cilindrica (L2,L3,h0,h1,h2,x3,y3,z3):
    
    q1=math.atan2(-x3/math.sqrt(x3^2+y3^2),y3/math.sqrt(x3^2+y3^2))
    q2=z3-(h0+h1+h2)
    q3=(x3^2+y3^2)/math.sqrt(x3^2+y3^2)-(L2+L3)
    
    spaceArticular = [q1,q2,q3]
    return spaceArticular

def function_esferica (L1,L2,L3,h0,h1,x3,y3,z3):
    
    beta2=-L1
    beta1 = h0
    w1=y3*math.sqrt(x3^2+y3^2-beta2^2)-x3*beta2
    w2=x3*math.sqrt(x3^2+y3^2-beta2^2)+y3*beta2
    
    q1=-math.atan2(w2,w1)
    
    w3=z3-(h1+math.beta1)
    w4=math.sqrt(x3^2+y3^2-beta2^2)
    
    q2=pi/2+math.atan2(w4,w3)
    q3=math.sqrt(x3^2+y3^2-beta2^2+(z3-(h1+beta1))*(z3-(h1+beta1)))-(L2+L3)
    
    spaceArticular = [q1,q2,q3]
    return spaceArticular

def function_angular (L1,L2,L3,h0,h1,x3,y3,z3):
    
    beta2=-L1
    l2=-L2
    l3=-L3
    z0=-z3+(h0+h1)
    beta3 = 0

    v1=math.sqrt(x3*(x3+y3*(y3-(beta2+beta3)^2)))
    q1=math.atan(y3/x3)-math.atan((beta2+beta3)/v1)
    c3=(x3*(x3+y3)*(y3+z3)*(z3-l2^2-l3^2))/(2*l2*l3)
    s3=math.sqrt((1-c3)*c3)
    q3=math.atan2(s3,c3)
    s2=(z3*((l2+l3)*c3)-l3*s3*(math.sqrt(x3*((x3+y3)*y3))))/(x3*(x3+y3*((y3+z3)*z3)))
    c2=(((l2+l3)*c3)*(math.sqrt(x3*((x3+y3)*y3))+(l3*s3)*z0))/(x3*((x3+y3)*((y3+z3)*z3)))
    q2=math.atan2(s2,c2)
    spaceArticular = [q1,q2,q3]

    return spaceArticular


function_doSeguimiento(1, "momo")