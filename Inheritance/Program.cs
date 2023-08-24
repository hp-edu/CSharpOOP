var knife = new Knife("Steel", 7.5);
knife.DisplayStatus();
knife.Use();
knife.Sharpen();
knife.Clean();

Util.LineBreakWithDashes(50);

var spoon = new Spoon("Plastic", 2.5);
spoon.DisplayStatus();
spoon.Use();
spoon.Clean();

Util.LineBreakWithDashes(50);

var fork = new Fork("Silver", 4);
fork.DisplayStatus();
fork.Use();
fork.Bend();
fork.Clean();
