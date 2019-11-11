using System;

namespace BeetlesAndStones
{
    class Program
    {
        static void Main(string[] args)
        {
            uint stones, beetles;
            long idexLastBeetle = 0;
            uint rangeLeft = 0;
            uint rangeRight = 0;

            Stone[] stonesArray;
            Beetle[] beetlesArray;

            Console.Write("Введите кол-во камней: ");
            stones = Convert.ToUInt32(Console.ReadLine());
            stonesArray = new Stone[stones];

            Console.Write("Введите кол-во жуков (не превышающее кол-во камней): ");
            beetles = Convert.ToUInt32(Console.ReadLine());
            beetlesArray = new Beetle[beetles];

            for (uint i = 0; i < stonesArray.Length; i++)
            {
                stonesArray[i] = new Stone();
            }

            for (uint i = 0; i < beetlesArray.Length; i++)
            {
                beetlesArray[i] = new Beetle();
            }


            /*for (uint i = 0; i < stonesArray.Length; i++)
            {
                Console.WriteLine(stonesArray[i].id);
            }
            for (uint i = 0; i < beetlesArray.Length; i++)
            {
                Console.WriteLine(beetlesArray[i].id);
            }*/



            Beetle b1 = new Beetle();
            Stone s1 = new Stone();
            //s1.beetle = b1;


            //stonesArray[0].beetle = b1;
            //stonesArray[1].beetle = b1;
            //stonesArray[2].beetle = b1;
            //stonesArray[3].beetle = b1;
            //stonesArray[4].beetle = b1;
            //stonesArray[5].beetle = b1;
            //stonesArray[6].beetle = b1;

            //Range.range(stonesArray);

            for (uint i = 0; i < beetlesArray.Length; i++) //Разбеш жуков по камням
            {
                Range.range(stonesArray);
                //Console.WriteLine(Range.center);
                stonesArray[Range.center].beetle = beetlesArray[i];

                if (i == beetlesArray.Length - 1)
                {
                    idexLastBeetle = Range.center;
                }

               /* for (uint j = 0; j < stonesArray.Length; j++)  //Вывод массива камней для проверки
                {
                    if (stonesArray[j].beetle == null)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write(stonesArray[j].beetle.id);
                    }
                }
                Console.WriteLine();*/
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("================================================================================");

            for (long i = idexLastBeetle + 1; i < stonesArray.Length; i++)
            {
                if (i < stonesArray.Length)
                {
                    if (stonesArray[i].beetle == null)
                    {
                        rangeRight += 1;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            for (long i = idexLastBeetle - 1; i >= 0; i--)
            {
                if (i >= 0)
                {
                    if (stonesArray[i].beetle == null)
                    {
                        rangeLeft += 1;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.WriteLine($"Последний жук находится под {idexLastBeetle+1}-м камнем. ID жука: {stonesArray[idexLastBeetle].beetle.id}.");
            Console.WriteLine();
            Console.WriteLine($"Свободных камней слева: {rangeLeft}");
            Console.WriteLine($"Свободных камней справа: {rangeRight}");
            Console.WriteLine();
            Console.WriteLine("Схема расположения каждого жука (число - занятый камень, с ID жука.   _ - пустой камень:");
            for (uint i = 0; i < stonesArray.Length; i++)  //Вывод массива камней для проверки
            {
                if (stonesArray[i].beetle == null)
                {
                    Console.Write("_ ");
                }
                else
                {
                    Console.Write(stonesArray[i].beetle.id + " ");
                }
            }





            //Console.WriteLine();
            //Console.WriteLine(Range.len);
            //Console.WriteLine(Range.hmax);
            //Console.WriteLine(Range.lmin);
            //Console.WriteLine(Range.center);
            Console.ReadKey();
        }

    }
}
