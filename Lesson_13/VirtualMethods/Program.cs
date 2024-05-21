namespace VirtualMethods
{/*
    Для роботи з віртуальними методами компілятор формує таблицю віртуальних методів 
    (Virtual Method Table або VMT). До неї записуються адреси віртуальних методів. До кожного класу створюється своя таблиця.

    Коли створюється об'єкт класу, компілятор передає в конструктор об'єкта спеціальний код, який пов'язує об'єкт і таблицю VMT.
    
    А за виклику віртуального методу з об'єкта береться адреса його таблиці VMT. 
    Потім з VMT витягується адреса методу і передається управління. 
    Тобто процес вибору реалізації методу провадиться під час виконання програми.
    Власне, так і виконується віртуальний метод. 
    Слід враховувати, що оскільки середовищі виконання спочатку необхідно отримати з таблиці VMT адресу потрібного методу,
    це трохи уповільнює виконання програми.
  */

    internal class Program
    {
        /*    1. Поліморфізм. Це означає, що ви можете викликати методи об'єкта, не знаючи його точний тип під час компіляції. 
              2. Універсальність коду: Це дозволяє писати більш універсальний код, який може працювати з будь-яким типом, 
                 який наслідується від базового класу. 
              3. Можемо викликати методи об'єкта, не знаючи його точний тип під час компіляції. 
              4. Можливість пізнього зв'язування (late binding):
                 Це означає, що вибір конкретної реалізації методу здійснюється під час виконання програми, 
                 а не під час компіляції. Це дозволяє використовувати різні реалізації методів в залежності від типу об'єкта, 
                 на який вказує змінна.

           Це дає гнучкість і дозволяє використовувати переваги поліморфізму, що робить код більш універсальним і розширюваним.

         */
        static void Main(string[] args)
        {
            // The objects of the derived class
            Automobile automobile1 = new Automobile("Toyota", 365, 4);
            Bicycle bicycle1 = new Bicycle("Trek Emonda SLR 9", 35, "Road bike");


            // Цей підхід дозволяє використовувати об'єкт похідного класу (Automobile) як об'єкт базового класу (Transport)
            Transport automobile2 = new Automobile("Porshe", 450, 2);  // --посилання на об'єкт зберігається у змінній базового типу !!!


            // Calling a replacement method in an object of a derived class
            automobile1.Move();
            bicycle1.Move();

            // Calling a replacement method in an object of a base class
            automobile2.Move();


            //Поліморфізм
            Transport[] transArray = { new Automobile("BMW", 365, 4), new Bicycle("Super Bicycle", 35, "Road bike") };
            foreach (Transport trans in transArray) 
            {
                trans.Move();
            }


            // не знаючи його точний тип під час компіляції
            Transport transForBuying;
            int money = 5000;
            if (money > 10000) 
            {
                transForBuying = new Automobile("BMW", 365, 4);
            }
            else
            {
                transForBuying = new Bicycle("Super Bicycle", 35, "Road bike"); 
            }
            transForBuying.Move();


            // Універсальність коду
            var transManager = new TransportManager();
            foreach (Transport trans in transArray)
            {
                transManager.MoveTransport(trans);
            }


        }
    }
}