using System;
using System.Diagnostics.CodeAnalysis;

namespace Uppgift_2
{
    class Maraton
    {
        

        static void Main(string[] args)



        {

            int BestTime = 1000000;
            


            int antalTävlande = 0, startNr = 0, startHour = 0, startMinute = 0, startSecond = 0, goalHour = 0,
                goalMinute = 0, goalSecond = 0, BestStartNumber = 0, result = 0;

            bool maratonKörs = true;         
                                 
            while (maratonKörs)
            {
                int BestTime1 = BestTime;
                int secs = BestTime1;
                int hours = BestTime1 / 3600;
                int mins = (BestTime1 % 3600) / 60;
                secs = BestTime1 % 60;



                Console.Write("\n\nAnge startnummer: ");
                int startNummerSiffra;
                if (int.TryParse(Console.ReadLine(), out startNummerSiffra))
                    startNr = startNummerSiffra;
                {
                    if (startNummerSiffra <= 0 && antalTävlande >= 1)
                    {

                        Console.WriteLine($"Startnummer {BestStartNumber} är vinnaren!");
                        Console.WriteLine($"Vinnande sluttid: {hours} timmar {mins} minuter {secs} sekunder");
                        Console.WriteLine($"Antal tävlande: {antalTävlande}");
                        Console.WriteLine("Programmet avslutas.");
                        break;
                    }
                    else if (startNummerSiffra <= 0 && antalTävlande <= 0)
                    {
                        Console.WriteLine("Inga tävlande.");
                        Console.WriteLine("Programmet avslutas.");
                        break;
                    }
                }

               Console.Write("\nAnge timme för start (0-23): ");
                int startTimmeNum;
                if (int.TryParse(Console.ReadLine(), out startTimmeNum))
                startHour = startTimmeNum;
                startHour *= 3600;
                    {
                        if (startTimmeNum < 0 || startTimmeNum > 24)
                        {
                            Console.Clear();
                            Console.Write("Ogilltig starttimme.");
                        }


                    }
                Console.Write("\nAnge minut för start (0-59): ");
                int startMinutNum;
                if (int.TryParse(Console.ReadLine(), out startMinutNum))
                startMinute = startMinutNum;
                startMinute *= 60;
                        {
                            if (startMinutNum < 0 || startMinutNum > 60)
                            {
                                Console.Clear();
                                Console.Write("Ogilltig startminut.");
                            }

                        }
                Console.Write("\nAnge sekund för start (0-59): ");
                int startSekundNum;
                if (int.TryParse(Console.ReadLine(), out startSekundNum))
                startSecond = startSekundNum;
                            {
                                if (startSekundNum < 0 || startSekundNum > 60)
                                {
                                    Console.Clear();
                                    Console.Write("Ogilltig startminut.");
                                }
                            }  
                Console.Write("\nAnge timme för mål (0-23): ");
                int målTimmeNum;
                if (int.TryParse(Console.ReadLine(), out målTimmeNum))
                goalHour = målTimmeNum;
                goalHour *= 3600;
                {
                    if (målTimmeNum < 0 || målTimmeNum > 24)
                     {
                        Console.Clear();
                        Console.Write("Ogilltig måltimme.");
                    }

                }

                Console.Write("\nAnge minut för mål (0-59): ");
                int målMinutNum;
                if (int.TryParse(Console.ReadLine(), out målMinutNum))
                goalMinute = målMinutNum;
                goalMinute *= 60;
                {
                    if (målMinutNum < 0 || målMinutNum > 60)
                    {
                        Console.Clear();
                        Console.Write("Ogilltig målminut.");

                    }
                }

                Console.Write("\nAnge sekund för mål (0-59): ");
                int målSekundNum;
                if (int.TryParse(Console.ReadLine(), out målSekundNum))
                goalSecond = målSekundNum;
                {
                    if (målSekundNum < 0 || målSekundNum > 60)
                    {
                        Console.Clear();
                        Console.Write("Ogilltig målminut.");

                    }

                }   
                Console.ReadLine();

                antalTävlande++;

                int startResult = startHour + startMinute + startSecond;
                int goalResult = goalHour + goalMinute + goalSecond;
                
                if (startResult > goalResult)
                {

                    int diff1 = 86400 - startResult;
                    int diff2 = diff1 + goalResult;
                    result = diff2;

                }
                else
                {
                    result = goalResult - startResult;
                }
               
                

                   



                






                Console.WriteLine($"Detta är startresultatet: {startResult} och detta är målresultatet: {goalResult}");
/*------------------------------------------------------------------------------------------------------------------------------ */

              
               
                if (result < BestTime)
                {
                    Console.WriteLine($"Det här är BestTime: {BestTime} och det här är resultatet: {result}");
                    BestTime = result;
                    BestStartNumber = startNr;
                    

                }
                
                    
            }
            
          
            /*------------------------------------------------------------------------------------------------------------------------------ */
            
            













            Console.ReadLine();




        }
       
    }
}         
     







       



    
         
          
                

                


                    
                       

                    
                
                


                    
                      
                    
                    

                

                
                


                   
                
                


                    
                       

                    

                
                
                


                    




                
            



            

           


           
































              
            
            


            
























