// -------------------- DIRECTIONS --------------------

// When someone asks you to think of a "drink", what comes to mind? 
// Perhaps you thought of a glass of water, a cup of coffee, or a 
// pint of beer. "Drink" is a very generic word used to describe a 
// wide variety of possible outcomes. But at the end of the day, 
// there are certain characteristics we could use to describe any 
// drink. We could describe a drink based on color, temperature, 
// whether or not it's carbonated and much more. We will be using 
// the idea of a basic "drink" to build out a series of more 
// defined drinks using inheritance.
// Directions

// Practice the OOP concepts of inheritance and polymorphism to 
// complete the following assignment.
// Making a Drink

// We will begin with our parent class. Take a moment to think: what 
// are the basic components of any drink? Once you have these in mind, 
// we will begin to build our class. Below is an example of a basic 
// Drink class, but you are free to add any features you feel are 
// missing.

Soda DrPepper = new Soda("Dr Pepper", "Brownish / Red", false, 150);
Coffee Mocha = new Coffee("Mocha", "Tan", 185, false, 360, "Dark", "Columbian");
Wine PinotNoir = new Wine("Pinot Noir", "Red", 55, 120, 2002, "France");

List<Drink> AllBeverages = new List<Drink>() {DrPepper, Mocha, PinotNoir};

foreach (Drink d in AllBeverages)
{
    d.ShowDrink();
}

// Coffee MyDrink = new Soda();
// This wont work Since you are making it the type of Coffee and creating a Soda so the
// Classes dont match
// also because Soda and Coffee have different constructors the compilier throws and error.