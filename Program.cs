using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace лаба5
{ /* Автомобиль, Поезд, Транспортное средство, Экспресс, Двигатель, 
Вагон.*/ 

   /* enum Transp
    {
        Lastochka, Mersedes
    }*/
    public abstract  class Transport
    {

        public int Number;
        public int Year;
        
        protected Transport() { }

        protected Transport (int number, int year)
        {
            Number = number;
            Year = year;
        }

        public override string ToString()
        {
            return "Транспорт " + Number + " собранный в  " + Year + "году";
        }
        public abstract bool DoClone();
    }
     class Train : Transport//, IClonable
    {
        public override bool DoClone()
        {
            return true;
        }
        public int Сarriages;
        public Train() { }
        public Train(int Number, int Year, int Carriages)
        {
            this.Number = Number;
            this.Year = Year;
            this.Сarriages = Carriages;
            
        }

        public override string ToString()
        {
            return "Поезд номер " + Number + " собранный в  " + Year + " году содержит " + Сarriages + "вагонов";
        }
    }

    class Car : Transport
    {
        public override bool DoClone()
        {
            return true;
        }
        
        public Car() { }
        public Car(int Number, int Year, int Speed)
        {
            this.Number = Number;
            this.Year = Year;
            this.Speed = Speed;

        }
        public double Speed;
        public override string ToString()
        {
            return " Машина номер " + Number + " собранная в  " + Year + " имеет скорость " + Speed ;
        }
    }
     class Engine: Car
    {
        public override bool DoClone()
        {
            return true;
        }
        public double Power;

        public Engine() { }
        public Engine(int Number, int Year, int Speed, int Power)
        {
            this.Number = Number;
            this.Year = Year;
            this.Speed = Speed;
            this.Power = Power;


        }

        public override string ToString()
        {
            return " Машина номер " + Number + " собранная в  " + Year + "  имеет скорость " + Speed + " Имеет двигатель силой" + Power;
        }
    }
     class Express: Train
    {
        public void Death()
        {
            Console.WriteLine("Вас сбили, попробуйте заново");
        }
        public override bool DoClone()
        {
            return true;
        }
        public double Speed;

        public Express() { }
        public Express(int Number, int Year, int Сarriages, int Speed )
        {
            this.Number = Number;
            this.Year = Year;
            this.Сarriages = Сarriages;
            this.Speed = Speed;


        }
        public override string ToString()
        {
            return " Поезд номер " + Number + " собранный в  " + Year + " имеет  " + Сarriages + " вагонов и скорость " + Speed;
        }
    }
    //partial
     sealed class Carriage : Express
    {
        public override bool DoClone()
        {
            return false;
        }
        public  int Seats;
        public Carriage() { }
        public Carriage(int Number, int Year, int Сarriages, int Speed, int Seats)
        {
            this.Number = Number;
            this.Year = Year;
            this.Сarriages = Сarriages;
            this.Speed = Speed;
            this.Seats = Seats;
        }

        public override string ToString()
        {
            return " Поезд номер " + Number + " собранный в  " + Year + " имеет  " + Сarriages + " вагонов, мест " + Seats  + " и скорость " + Speed ;
        }
    }
       /* 
    }*/
    
    interface IClonable
    {
        bool DoClone();
    }
     class Printer
    {
        public string IAmPrinting(Transport someobj)
        {
            return someobj.ToString();
        }
        public string IAmPrinting(Car someobj)
        {
            return someobj.ToString();
        }
        public string IAmPrinting(Train someobj)
        {
            return someobj.ToString();
        }
    }

    


    
}

