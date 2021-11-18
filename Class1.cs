using System;
using System.Collections.Generic;

namespace лаба5
{
    class Programm
    {
        interface IUps
        {
            void Break();
            void Sale();
        }
        static void Main(string[] args)
        {

            Car car = new Car(5689, 2009, 102);
            Console.WriteLine(car.ToString());
            Train train = new Train(562, 1992, 3);
            Console.WriteLine(train.ToString());
            Engine engine = new Engine(864318, 1998, 120, 2009);
            Console.WriteLine(engine.ToString());
            Express express = new Express(879, 2020, 6, 360);
            Console.WriteLine(express.ToString());
            express.Death();
            Carriage carriage = new Carriage(622, 1980, 3, 50, 250);
            Console.WriteLine(carriage.ToString());

            /*
            Random rand = new Random();
            Transport[] arr = new Transport[5];
            for(int i = 0; i < arr.Length; i++)
            {
                switch(rand.Next(5))
                {
                    case 0:
                        {
                            arr[0] = new Car(5689, 2009, 102);
                        break; }
                        
                   case 1:
                        {arr[1] = new Train(562, 1992, 3);
                        break; }
                        
                    case 2:
                        {arr[2] = new  Engine(864318, 1998, 120, 2009);
                        break; }
                        
                    case 3:
                        { arr[3] = new Express(879, 2020, 6, 360);
                        break;}
                        
                    case 4:
                        {arr[4] = new Carriage(622, 1980, 3, 250, 50);
                        break; }
                        
                }
            }
          

            foreach (var transport in arr)
                {
                    transport.Info();
                }
            }*/

            List<Transport> list = new List<Transport> { new Train(562, 1992, 3), new Car(5689, 2009, 102) };

            Printer printer = new Printer();
            foreach (Transport v in list)
            {
                Console.WriteLine(printer.IAmPrinting(v));
            }

            Composition composition = new Composition();

            

            
            composition.cp.Add(engine);
            composition.cp.Add(express);
            composition.cp.Add(carriage);

            composition.GetTr("car");
            composition.GetTransport(2);
             //Controller controller = new Controller();
        }

        public partial class Composition
        {
            public List<object> cp = new System.Collections.Generic.List<object>();
            public void GetTr(string trans)
            {
                foreach (Transport v in cp)
                {
                    //Console.WriteLine(v.Transport);
                }
            }
            public void GetTransport(int num)
            {
                string buf;
                for (int i = 0; i < cp.Count; i++)
                {
                    buf = Convert.ToString(cp[i]);
                    if (buf.Contains(Convert.ToString(num)))
                    { Console.WriteLine(buf); }
                }
            }
        



        }
    }
}
