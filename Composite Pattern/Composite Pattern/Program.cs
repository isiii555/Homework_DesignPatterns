using Composite_Pattern.Abstract;
using Composite_Pattern.Concretes;

Computer comp = new("Asus");
comp.AddPart(new Mouse("Razer", 2000));
comp.AddPart(new Keyboard("SteelSeries", 2000));
comp.AddPart(new Ram("Corsair", 2000));
comp.AddPart(new Videocard("AMD", 2000));
comp.GetPrice();