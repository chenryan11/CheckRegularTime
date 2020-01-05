using System;
using System.Collections.Generic;
using System.Text;

namespace CheckRegularTime
{
    class RegularTime
    {
        public void MilitaryTimeToRegularTime()
        {
            //DateTime datetime;

            string[] m_slInPut = new string[1];

            string m_sInPut = "";

            int m_iInputHur = 0, m_iInputMin = 0;

            string m_sAMorPM = "";

            bool bWhile = true;
            //判斷輸入
            while (bWhile)
            {
                m_sInPut = Console.ReadLine();

                //把輸入的字串用冒號分割，放進陣列
                try
                {
                    m_slInPut = m_sInPut.Split(':');
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp);
                    Console.WriteLine("分割失敗");
                    break;
                }

                if (m_slInPut != null) //m_lInPut不為空
                {
                    //小時
                    if (int.TryParse(m_slInPut[0], out m_iInputHur))
                    {
                        if (m_iInputHur <= 24 && m_iInputHur >= 0)
                        {
                            if (m_iInputHur < 12 || m_iInputHur == 24)
                            {
                                m_sAMorPM = "AM";

                                if (m_iInputHur == 24)
                                {
                                    m_iInputHur = 00;
                                }
                            }
                            else
                            {
                                m_sAMorPM = "PM";

                                if(m_iInputHur != 12)
                                {
                                    m_iInputHur -= 12;
                                }                                
                            }
                        }
                        else
                        {
                            Console.Write("error");
                            break;
                        }
                    }
                    else
                    {
                        Console.Write("int.TryParse(m_slInPut[0])失敗");
                        break;
                    }
                    //分鐘
                    if (int.TryParse(m_slInPut[1], out m_iInputMin))
                    {
                        if (m_iInputMin <= 60)
                        {
                            //輸出
                            Console.WriteLine(m_iInputHur + ":" + m_iInputMin + m_sAMorPM);
                            break;
                        }
                        else
                        {
                            Console.Write("error");
                            break;
                        }
                    }
                    else
                    {
                        Console.Write("error");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("m_lInPuth裡是空的");
                    break;
                }
            }

            //輸出
            //Console.WriteLine(m_iInputHur + ":" + m_iInputMin + m_sAMorPM);

            /*
            if (DateTime.TryParse(m_sInPut, out datetime))
            {


                Console.WriteLine(datetime);
            }
            else
            {
                Console.WriteLine("DateTime.TryParse is false");
            }
            */
        }
    }
}
