using System;
using System.Collections.Generic;
abstract class allatok
{
    public string Name { get; set; }
    public int Speed { get; set; }

    public allatok(string name, int speed)
    {
        Name = name;
        Speed = speed;
    }
}

class viziallat : allatok
{
    public viziallat(string name, int speed) : base(name, speed) { }
}

class hidegallat : allatok
{
    public hidegallat(string name, int speed) : base(name, speed) { }
}

class mediterranallat : allatok
{
    public mediterranallat(string name, int speed) : base(name, speed) { }
}

class melegallat : allatok
{
    public melegallat(string name, int speed) : base(name, speed) { }
}

class tropusiallat : allatok
{
    public tropusiallat(string name, int speed) : base(name, speed) { }
}
