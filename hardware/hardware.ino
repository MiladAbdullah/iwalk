#include <SoftwareSerial.h>

#define M1CW 8 //CW of Motor 1 is defined as pin #7//
#define M1CCW 7 //CCW of Motor 1 is defined as pin #8//


#define M2CW 5 //CW of Motor 2 is defined as pin #4//
#define M2CCW 4 //CCW of Motor 2 is defined as pin #5//

String ss="";

void setup() 
{
    Serial.begin(9600);
    pinMode(M1CW ,OUTPUT);
    pinMode(M1CCW,OUTPUT);
    pinMode(M2CW ,OUTPUT);
    pinMode(M2CCW,OUTPUT);
}
  

void loop() 
{ 
  while(Serial.available())
  {
    ss=Serial.readString();
  }
  
  switch(ss.toInt())
  {
   case 0:                   // stop both motors
      Stop();
   
  break;
  case 1:
  MoveForward();
    
  break;
   case 2:
    RotateLeft();
    
  break;   
  case 3:
    RotateRight();
    
  break;
  
  }  
}


void Stop()
{
    digitalWrite(M1CW,LOW);
    digitalWrite(M1CCW,LOW);
    digitalWrite(M2CW,LOW);
    digitalWrite(M2CCW,LOW);
}

void MoveForward()
{
    digitalWrite(M1CW,HIGH);
    digitalWrite(M1CCW,LOW);
    digitalWrite(M2CW,LOW);
    digitalWrite(M2CCW,HIGH);
}
void RotateLeft()
{
   digitalWrite(M1CW,LOW);
    digitalWrite(M1CCW,HIGH);
    digitalWrite(M2CW,LOW);
    digitalWrite(M2CCW,LOW);
}

void RotateRight()
{
   digitalWrite(M1CW,LOW);
    digitalWrite(M1CCW,LOW);
    digitalWrite(M2CW,HIGH);
    digitalWrite(M2CCW,LOW);
}
