using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;


public abstract class Enemy : Entity
{
    public int Column { get; set; }
    public int Line { get; set; }

    public abstract void Move();
    public abstract void Build();
}

public class Rock : Enemy
{
    public override void Build()
    {
        Column = random(1000);
        Line = 0;
        build(0, 0, 40, 40); // Corpo não deslocado do centro original com tamanho 40x40
    }

    public override void Move()
    {
        Line++; //Cai
    }
}




public class TwoRock : Enemy
{
    public override void Build()
    {
        Column = random(1000);
        Line = 0;
        build(-60, 0, 40, 40); // Corpo deslocado do centro
        build(60, 0, 40, 40); // Outro corpo deslocado na outra direção
    }

    public override void Move()
    {
        Line += 3; //Cai mais rápido
        Column++; //Cai em diagonal
    }
}



public class NoMoveEnemmy : Enemy
{
    public override void Build()
    {
        Column = 500;
        Line = 500;
        build(0, 0, 30, 30);
    }

    public override void Move()
    {
        Line = Line;
        Column = Column;
    }
}


public class Palito : Enemy
{
    public override void Build()
    {
        Column = random(1000);
        Line = 0;
        build(0, 0, 40, 301);
    }

    public override void Move()
    {
        Line+=3; 
        Column++;
    }
}



public class Plataform : Enemy
{
    public override void Build()
    {
        Column = random(250);
        Line = 0;
        build(1100, 0, 1000, 150);
        build(-100, 0, 1000, 150);
    }

    public override void Move()
    {
        Line+=2; 
        // Column++;
    }
}

public class Aleatory : Enemy
{
    public override void Build()
    {
        Column = 500;
        Line = 500;
        build(0, 0, 30, 30);
    }

    public override void Move()
    {
        Line ++;
        Column += (random(6)-3);
    }
}

public class Teleporter : Enemy
{
    public override void Build()
    {
        Column = random(1000);
        Line = 0;
        build(0, 0, 50, 50);
    }
    public override void Move()
    {
        
        Line = random(1000);
        Column = random(1000);
        System.Threading.Thread.Sleep(2000);
    }
}



public class ExtremamenteRapido : Enemy
{
    public override void Build()
    {
        Column = random(1000);
        Line = 0;
        build(0, 0, 50, 50);
    }
    public override void Move()
    {
        Line +=15;
    }
}
public class HorizontalMover : Enemy
{
    public string direction = "left"; 
    public override void Build()
    {
        Column = 500;
        Line = 1000;
        build(0, 0, 50, 50);
    }
    public override void Move()
    {
        if(Column < 5)
            direction = "left";
        else if (Column >1700)
            direction = "right";
        
        if(direction == "left")
            Column+=5;
        if(direction == "right")
            Column-=5;
    }
}



