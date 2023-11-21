const int ledBLUE = 9;
  const int ledRED = 10;
  const int ledGREEN = 8;

  int LDR_pinBLUE = 0;
  int LDR_pinGREEN = 1;
  int LDR_pinRED = 2;

  int LDR_Calc = 0;
  int LDR_var = 0;
  int ciclo;
  int divisor;
  int i = 0;
  boolean stringComplete = false;
  String inputString = "";

  void setup() 
  {
    // put your setup code here, to run once:
    Serial.begin(9600);    //iniciar puerto serie
    pinMode(ledRED, OUTPUT);  //definir pin como salida impar
    pinMode(ledBLUE, OUTPUT);  //definir pin como salida par
    pinMode(ledGREEN, OUTPUT);  //definir pin como salida divisor
  }

  static bool EsPar(int numero)
  {
    return numero % 2 == 0;
  }

  void encender() 
  {
    if (i % divisor == 0) 
    {
      if (EsPar(i)) 
      {
        digitalWrite(ledGREEN, HIGH); // divisor x5000
        digitalWrite(ledBLUE, HIGH); // par azul x1000
        LDR_Calc = analogRead(LDR_pinBLUE * 1000);
        LDR_var = analogRead(LDR_pinGREEN * 5000) + LDR_Calc;
        Serial.println(LDR_var);
        LDR_Calc = 0;
        LDR_var = 0;
      } 
      else 
      {
        digitalWrite(ledGREEN, HIGH); // divisor x 5000
        digitalWrite(ledRED, HIGH); // impar rojo x3000
        LDR_Calc = analogRead(LDR_pinRED * 3000);
        LDR_var = analogRead(LDR_pinGREEN * 5000) + LDR_Calc;
        Serial.println(LDR_var);
        LDR_Calc = 0;
        LDR_var = 0;
      }
    } 
  else 
  {
    if (EsPar(i)) 
    {
    digitalWrite(ledBLUE, HIGH); // par azul x1000
    LDR_var = analogRead(LDR_pinBLUE * 1000);
    Serial.println(LDR_var);
    LDR_var = 0;
    } 
    else 
    {
    digitalWrite(ledRED, HIGH); // impar rojo x 3000
    LDR_var = analogRead(LDR_pinRED * 3000);
    Serial.println(LDR_var);
    LDR_var = 0;
    }
  }

  delay(1000);

  // Apaga todos los LEDs al final de cada ciclo
  digitalWrite(ledGREEN, LOW);
  digitalWrite(ledRED, LOW);
  digitalWrite(ledBLUE, LOW);

  delay(1000);            
  }

  void serialEvent() 
  {
    while (Serial.available()) 
    {
      char inChar = (char)Serial.read();
      if (inChar == '\n') 
      {
        ciclo = inputString.substring(0, inputString.indexOf('#')).toInt();
        divisor = inputString.substring(inputString.indexOf('#') + 1).toInt(); // Asigna el divisor

        stringComplete = true; // Se ha recibido una línea completa
      } 
      else 
      {
        inputString += inChar; // Agregar el carácter al buffer
      }
    }
  }

  void loop() 
  {
    if (stringComplete) 
    {
      if (i < ciclo) 
      {
        encender();
        i++;
      }
      else
      {
        digitalWrite(ledGREEN , LOW); 
        digitalWrite(ledBLUE , HIGH); 
        digitalWrite(ledRED , LOW); 
        inputString = "";
        stringComplete = false;
        i = 0;
      }    
    }
  }