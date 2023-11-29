#include <LiquidCrystal.h>

LiquidCrystal lcd(12, 10, 5, 4, 3, 2);  //define LCD pins (RS, E, D4, D5, D6, D7)

int luz;
int humedad;
String estadoHumedad;
String estadoLuz;

String i;
char mystr[6]; //String data

void setup() {
  
Serial.begin(9600);

}

void loop() {

sensorLuz();

sensorHumedad();

pantallaLCD();

enviodatos();

String txtHumedad = String(humedad);
String txtLuz = String(luz);

}

void enviodatos() {
  // put your main code here, to run repeatedly:
  String i;
  char mystr[6]; //String data
  String txtHumedad = String(luz);
  String txtLuz = String(humedad);
  i = "1" + txtHumedad + txtLuz;
  i.toCharArray(mystr,6);
  Serial.write(mystr,6); //Write the serial data
  //Serial.write(13);
  Serial.println();
  delay(2000);
}

void sensorLuz(){

luz = analogRead(A0); 
luz = constrain(luz,80,500);  //Keep the ranges!
luz = map(luz,500,80,10,99);  //Map humedad : 400 will be 100 and 1023 will be 0 

if (luz < 30) 
{
    estadoLuz = "Bajo";
} 
else if (luz < 70) 
{
    estadoLuz = "Normal";
} 
else if (luz > 70) 
{
    estadoLuz = "Alto";
} 
}

void sensorHumedad(){

const int sensorH = A5;  //Hygrometer sensor analog pin output at pin A0 of Arduino

humedad = analogRead(sensorH); 
humedad = constrain(humedad, 400, 1023);  //Keep the ranges!
humedad = map(humedad, 1023, 400,10,99);  //Map humedad : 400 will be 100 and 1023 will be 0 
//Serial.println(humedad);
if (humedad < 30) 
{
   estadoHumedad = "Bajo";
} 
else if (humedad < 50) 
{
    estadoHumedad = "Normal";
} 
else if (humedad < 100) 
{
    estadoHumedad = "Alto";
} 
}

void pantallaLCD(){
  
lcd.begin(16, 2);
lcd.clear();
lcd.setCursor(0, 0);
lcd.print("Luz: " + estadoLuz);
lcd.setCursor(0, 1);
lcd.print("Humedad: " + estadoHumedad);
delay(500);
}
