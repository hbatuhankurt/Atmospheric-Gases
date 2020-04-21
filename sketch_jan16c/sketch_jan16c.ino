//Library
#include "DHT.h"
#include "MQ7.h"

//Vars
#define MQ135_A_PIN A0
#define DHT11_D_PIN 2
#define MQ7_A_PIN A1
#define MQ2_A_PIN A2

//DHT11
#define DHTTYPE DHT11 
DHT dht(DHT11_D_PIN, DHTTYPE);

//MQ7
MQ7 mq7(MQ7_A_PIN,5.0);

void setup(){
  Serial.begin(9600);
  dht.begin();
  pinMode(MQ2_A_PIN, INPUT);
  pinMode(MQ135_A_PIN,INPUT);
}

void loop()
{ 
  double dht11_h = dht.readHumidity();
  double dht11_t = dht.readTemperature();
  double mq7_co = mq7.getPPM();
  double mq2_smoke = analogRead(MQ2_A_PIN);
  double mq135_air = analogRead(MQ135_A_PIN);

  Serial.print(dht11_h);
  Serial.print("*");
  Serial.print(dht11_t);
  Serial.print("*");
  Serial.print(mq7_co);
  Serial.print("*");
  Serial.print(mq2_smoke);
  Serial.print("*");
  Serial.println(mq135_air);
  delay(100);
}
