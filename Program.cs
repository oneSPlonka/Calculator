using System;

namespace Calculator
{
    
    class Program
    {

        
        static void Main(string[] args)
        {
            string Name = "Reksio";
            string BredOfDog = "Owczarek";
            int Weight=5;
            string DateOfBirth="09.2021"; //Musi być stały format tego np. RRRR.MM.DD ale nas interesuje misąc i rok więc może być tylko RRRR.MM albo MM.RRRR Zrobimy MM.RRRR ale to łatwo pozmieniać
            int DogWork = 0;//od 0 do 10 : 0 nie pracuje 1-3 słabo 4-6 średnio 6-10 ciężko
            bool FatWeightLoseOrDietaAfterIntensivTerapy=false;//czy gróby true or false
            bool FatLowActiv = false;//czy gróby true or false
            bool Sterilized=true; //czy sterylizowany true or false
            bool Convalescence=false; //czypodczas rekonwalescencji true or false
            string Sex="male";//tu też można dać boola xD
            int PregnancyMonth=0;//default 0 bo nie w ciąży, chyba, że użytkownik wprowadzi dany miesiąc
            bool Feeding=false;//karmiące też bool true or false
            int QtyOfPuppies=0;
            double Calories;
            float CalculationFactor=0;
            double RER = 70 * Math.Pow(Weight, 3d / 4);
            
            
            int age = 24;




            //Wiek w miesiącach
            //czy szczenię Trzeba dorobić obliczanie wieku z daty urodzenia.



            // trageia z tą logika xD

            if (age <= 12)
            {
                if (age <= 5)
                {
                    CalculationFactor = 3;
                }
                else if (age <= 8)
                {
                    CalculationFactor = 2.5f;
                }
                else
                {
                    CalculationFactor = 1.8f;
                }
            }
            else
            {
                if (FatWeightLoseOrDietaAfterIntensivTerapy==true)
                {
                    CalculationFactor = 1;
                }
                else if (FatLowActiv == true)
                {
                    CalculationFactor = 1.4f;
                }
                else if(Convalescence==true)
                {
                    CalculationFactor = 1.3f;
                }
                else if(Sterilized==true)
                {
                    CalculationFactor = 1.6f;
                }
                else if (DogWork!=0)//nie równa się zero znaczy, pracujący
                {
                    if(DogWork<=3)//lekko pracujący
                    {
                        CalculationFactor = 2;
                    }
                    else if( DogWork<=6)//średnio pracujacy
                    {
                        CalculationFactor = 3;
                    }
                    else if(DogWork>6)//ciężko pracujący k=4-8
                    {
                        CalculationFactor = DogWork - 2;
                    }
                }
                else if(Sex=="female")
                {
                    if (PregnancyMonth > 0)//większy niż 0 więc w ciąży 
                    {
                        if(PregnancyMonth<=6)
                        {
                            CalculationFactor = 1.8f;
                        }
                        else if(PregnancyMonth>6)
                        {
                            CalculationFactor = 3;
                        }
                    }
                    if (Feeding==true)//jeśli true waruneczki ze szczeniaczkami na cycu
                    {
                        if (QtyOfPuppies == 1)
                        {
                            CalculationFactor = 3;
                        }
                        else if(QtyOfPuppies==2)
                        {
                            CalculationFactor = 3.5f;
                        }
                        else if(QtyOfPuppies==3||QtyOfPuppies==4)
                        {
                            CalculationFactor = 4;
                        }
                        else if(QtyOfPuppies==5||QtyOfPuppies==6)
                        {
                            CalculationFactor = 5;
                        }
                        else if(QtyOfPuppies==7||QtyOfPuppies==8)
                        {
                            CalculationFactor = 5.5f;
                        }
                        else if(QtyOfPuppies==9)
                        {
                            CalculationFactor = 6;
                        }
                    }

                }
            }


            //ostatecznie poprosimy wynik :)
            Calories = RER * CalculationFactor;
            Console.WriteLine((int)Calories);

            Console.WriteLine("Dla testów: Współcznnik = {0}",CalculationFactor);








        }
    }
}
