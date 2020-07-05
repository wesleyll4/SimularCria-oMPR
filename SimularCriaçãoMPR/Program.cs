using System;
using System.IO;
using System.Timers;

namespace SimularCriaçãoMPR
    {
    class Program
        {
        private static string NovoTexto;
        private static int Atual, Proximo, novo, i1, i2, j1, j2, x2, y1, a1, b1, c1, d1, e1, f1, g1, h1, k1, l1, m1, n1, a2, b2, c2, d2, e2, f2, g2, h2, k2, l2, m2, n2;
        private static string x, y, i, j, a, b, c, d, e, f, g, h, k, l ,m, n;
        private static Random rnd = new Random();
        private static string TextoBase = @"D:\kme\Base.mpr";

        private static Timer atimer;

        static void Main(string[] args)
            {
            try
                {
                atimer = new Timer();
                atimer.Interval = 5000;
                atimer.Elapsed += Atimer_Elapsed;
                atimer.AutoReset = true;
                atimer.Enabled = true;

                rnd.Next(0, 4);

                Atual = novo;


                i1 = 120;

                j1 = 203;

                a1 = 60;
                b1 = 55;
                c1 = 129;
                d1 = 14;
                e1 = 98;
                f1 = 10;
                g1 = 66;
                h1 = 230;
                k1 = 45;
                l1 = 111;
                m1 = 25;
                n1 = 78;




                Proximo = novo + 1;

                FileSystemWatcher watcher = new FileSystemWatcher(@"D:\kme\pt200\ProductReport\");
                watcher.Created += Watcher_Created;

                Console.WriteLine("Press the Enter key to exit the program at any time... ");
                Console.ReadLine();
                }
            catch (Exception e)
                {
                Console.WriteLine(e.Message);
                }
            }

        private static void Watcher_Created(object sender, FileSystemEventArgs e)
            {
            char[] separator = { '\\', '.' };
            string[] UltimoSeparado = e.FullPath.Split(separator);
            int ultimo = int.Parse(UltimoSeparado[5]);
            novo = ultimo + 1;


            }

        private static void criarArquivo()
            {
            try
                {
                y1 += rnd.Next(0, 5);
                x2 = x2 + rnd.Next(0, 4);

                i2 = i2 + i1;
                j2 = j2 + j1;
                a2 = a2 + a1;
                b2 = b2 + b1;
                c2 = c2 + c1;
                d2 = d2 + d1;
                e2 = e2 + e1;
                f2 = f2 + f1;
                g2 = g2 + g1;
                h2 = h2 + h1;
                k2 = k2 + k1;
                l2 = l2 + l1;
                m2 = m2 + m1;
                n2 = n2 + n1;







                y = y1.ToString();
                x = x2.ToString();

                i = i2.ToString();
                j = j2.ToString();

                a = a2.ToString();
                b = b2.ToString();
                c = c2.ToString();
                d = d2.ToString();
                e = e2.ToString();
                f = f2.ToString();
                g = g2.ToString();
                h = h2.ToString();
                k = k2.ToString();
                l = l2.ToString();
                m = m2.ToString();
                n = n2.ToString();



                Atual++;
                Proximo++;




                Console.WriteLine("Atual: " + Atual + " || Proximo: " + Proximo + " || X" + x + " || i: " + i + " || j: " + j + "   ");

                NovoTexto = @"D:\kme\pt200\" + Proximo + ".mpr";
                string NovoTextox = @"D:\kme\pt200\ProductReport\CM602-1\" + Proximo + ".mpr";


                string lines = File.ReadAllText(TextoBase).Replace("x", x).Replace("i", i).Replace("j", j).Replace("y", y).Replace("a" , a).Replace("b", b).Replace("c", c).Replace("d", d).Replace("e", e).Replace("f", f).Replace("g", g).Replace("h", h).Replace("k", k).Replace("l", l).Replace("m", m).Replace("n", n);
                if (File.Exists(NovoTexto) == false)
                    {
                    using (StreamWriter sw = File.CreateText(NovoTexto))
                        {
                        sw.WriteLine(lines);
                        File.Move(NovoTexto, NovoTextox);
                        sw.Close();
                        sw.Close();
                        };
                    }
                else
                    {
                    Console.WriteLine("arquivo existe");
                    }
                }
            catch (Exception ex)
                {

                Console.WriteLine(ex.Message);
                }

            }


        private static void Atimer_Elapsed(object source, ElapsedEventArgs e)
            {
            try
                {
                y1 += rnd.Next(0, 5);
                x2 = x2 + rnd.Next(0, 4);

                i2 = i2 + i1;
                j2 = j2 + j1;
                a2 = a2 + a1;
                b2 = b2 + b1;
                c2 = c2 + c1;
                d2 = d2 + d1;
                e2 = e2 + e1;
                f2 = f2 + f1;
                g2 = g2 + g1;
                h2 = h2 + h1;
                k2 = k2 + k1;
                l2 = l2 + l1;
                m2 = m2 + m1;
                n2 = n2 + n1;

                i2 = i2 + i1;
                j2 = j2 + j1;

                y = y1.ToString();
                x = x2.ToString();

                i = i2.ToString();
                j = j2.ToString();

                a = a2.ToString();
                b = b2.ToString();
                c = c2.ToString();
                d = d2.ToString();
                f = f2.ToString();
                g = g2.ToString();
                h = h2.ToString();
                k = k2.ToString();
                l = l2.ToString();
                m = m2.ToString();
                n = n2.ToString();


                Atual++;
                Proximo++;




                Console.WriteLine("Atual: " + Atual + " || Proximo: " + Proximo + " || Random: " + x + " || i: " + i + " || j: " + j + "   " + x);


                NovoTexto = @"D:\kme\pt200\ProductReport\CM602-1\" + "00" + Proximo + ".mpr";


                string lines = File.ReadAllText(TextoBase).Replace("x", x).Replace("i", i).Replace("j", j).Replace("y", y).Replace("a", a).Replace("b", b).Replace("c", c).Replace("d", d).Replace("f", f).Replace("g", g).Replace("h", h).Replace("k", k).Replace("l", l).Replace("m", m).Replace("n", n); ;
                if (File.Exists(NovoTexto) == false)
                    {
                    using (StreamWriter sw = File.CreateText(NovoTexto))
                        {
                        sw.WriteLine(lines);
                        sw.Close();
                        };
                    }
                else
                    {
                    Console.WriteLine("arquivo existe");
                    }
                }
            catch (Exception ex)
                {

                Console.WriteLine(ex.Message);
                }

            }
        }
    }
