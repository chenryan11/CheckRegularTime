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

            bool m_bWhile = true;

            bool m_bHur = false , m_bMin = false;

            //判斷輸入
            while (m_bWhile)
            {
                m_sInPut = Console.ReadLine();

                //把輸入的字串用冒號分割，放進陣列
                try
                {
                    m_slInPut = m_sInPut.Split(':');
                    //m_lInPut不為空
                    if (m_slInPut[0] != null &&
                       m_slInPut[1] != null) 
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

                                    m_bHur = true;
                                }
                                else
                                {
                                    m_sAMorPM = "PM";

                                    if (m_iInputHur != 12)
                                    {
                                        m_iInputHur -= 12;
                                    }

                                    m_bHur = true;
                                }
                            }
                            else
                            {
                                Console.WriteLine("小時輸入錯誤");
                            }
                        }
                        else
                        {
                            Console.WriteLine("int.TryParse(m_slInPut[0])失敗");
                        }
                        //分鐘
                        if (int.TryParse(m_slInPut[1], out m_iInputMin))
                        {
                            if (m_iInputMin <= 60)
                            {
                                m_bMin = true;
                            }
                            else
                            {
                                Console.WriteLine("分鐘輸入錯誤");
                                //break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("int.TryParse(m_slInPut[1])失敗");
                            //break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("m_lInPuth裡是空的");
                        //break;
                    }
                    //全部輸入正確跳開迴圈，顯示結果
                    if(m_bHur && m_bMin)
                    {
                        break;
                    }
                    else
                    {
                        m_bHur = false;
                        m_bMin = false;
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("error");
                }
            }

            //輸出
            Console.WriteLine(m_iInputHur + ":" + m_iInputMin + m_sAMorPM);

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
