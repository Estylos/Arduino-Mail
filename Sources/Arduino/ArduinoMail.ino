/*
Arduino Mail par Esteban Cadic le 18/06/2016
Partie : Arduino : C
*/

#define BUZZER 8 // BUZZER, PIN 8

String content = ""; 
char character;

void setup() // Fonction appelée au démarrage de l'Arduino  
{
  pinMode(BUZZER, OUTPUT); // BUZZER, sortie

  
  Serial.begin(9600); // On initialise la communication série (pour que l'ordinateur puisse communiquer et envoyer des informations en USB)
}

void loop() // Boucle infinie
{
  
  delay(50); // On attend 50 ms
  while(Serial.available()) { // Si des données entrantes sont présentes (du texte)
    character = Serial.read(); // On les récupères une par une (caractère par caractère)
    content.concat(character); // On ajoute les caractères un à la suite (exemple : s + i + x = six) 
  }
    
      
  if (content == "##1") { // Si on récupère "##1"
    tone(BUZZER, 2637, 350); // On joue une note de 2637 Hz (Mi) pendant 350 ms  
    delay(350);
    tone(BUZZER, 2349, 350); // On joue une note de 2349 Hz (Re) pendant 350 ms  
    delay(350);
    tone(BUZZER,  3136, 350); // On joue une note de 3136 Hz (Sol) pendant 350 ms  
    delay(350);
    content = ""; // On efface ce que l'ordinateur a envoyé précédemment
  }
    
  else if (content != "") { // Qi on récupère autre chose
    content = ""; // On efface ce que le l'ordinateur a envoyé précédemment
  }

}
