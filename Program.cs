using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uzduotys
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            ----------1a uzduotis-------------
            Sukurti metodą ReadIntNumber , kuris paprašo vartotojo
            įvesti sveikąjį skaičių ir tą skaičių grąžina. Jeigu vartotojas
            įveda blogą skaičių, tai programa turi informuoti, kad
            įvestas blogas skaičius ir prašyti įvesti vėl. Kol vartotojas
            neįveda tinkamo skaičiaus metodas turi vis prašyti įvesti.
            Panaudoti int.TryParse metodą ir while ciklą. 
            */
            //ReadIntNumber();

            /*
            -----------2a uzduotis---------------- 
            Parašyti metodą TryParseReloaded, kuris veikia taip pat kaip int.TryParse();
            */
            //Console.WriteLine(TryParseReloaded("25.0", out bool tiesa));

            /*
            -----------3ia uzduotis---------------- 
            Sukurti metodą IntegerToBinary, kuris gautą teigiamą sveikąjį skaičių paverstų į dvejetainį formatą. Reikšmę grąžintų kaip simbolių eilutę.
            2 --> 10
            7 --> 111
            45 --> 101101
            */
            //Console.WriteLine(IntegerToBinary("4"));

            /*-----------4ia uzduotis----------------
            Sukurti metodą PakeltiLaipsniu , kuris duotą skaičių pakelia nurodytu
            laipsniu ir gautą rezultatą grąžina. Pirmas parametras skaičius, kurį
            kelsime, antras laipsnis, kuriuo pakelti.
            */
            //Console.WriteLine(PakeltiLaipsniu(5, 3));

            /*-----------5ia uzduotis----------------
            Sukurti metodą BinaryToInteger, kuriam padavus simbolių eilutę su 1 ir 0 seka (dvejataini skaiciu), metodas grąžintų dešimtainį sveikąjį skaičių.
            */
            //Console.WriteLine(BinaryToInteger("111"));

            /*-----------6ia uzduotis----------------
            Sukurti metodą SentenceAnalysis
            Paduodama simbolių eilutė (sakinys). Metodas išanalizuoja, kiek ir kokių simbolių yra sakinyje.
            - Visa analizės informacija turi būti išsaugota žodyne(simbolis, pasikartojimai).
            - Tarpų neskaičiuoti ir į žodyną nedėti.
            1 Atspausdinti gautus rezultatus.
            2 Atspausdinti dažniausiai pasikartojantį simbolį.
            Jeigu yra keletas simbolių tiek pat pasikartojančių, atspausdinti juos visus.
            3 Atspausdinti rečiausiai pasikartojantį simbolį.
            Jeigu yra keletas simbolių tiek pat pasikartojančių, atspausdinti juos visus.
            */
            //SentenceAnalysis("Isanalizuokime si niekam tikusi teksta:");

            /*-----------7ia uzduotis----------------
            UŽDUOTIS 7.
            Sukurti metodą SkaiciuStatusTrikampis, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9 jeigu įveda
            netinkamą skaičių prašo įvesti vėl, kol įves tinkamą )). Programa turi atspausdinti
            atitinkamą statųjį trikampį.
            5
            55
            555
            5555
            55555
            */
            //SkaiciuStatusTrikampis();

            /*-----------8a uzduotis----------------
            UŽDUOTIS 7.
            Sukurti metodą SkaiciuTrikampis, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9
            jeigu įveda netinkamą skaičių
            prašo įvesti vėl, kol įves tinkamą )). Programa turi atspausdinti atitinkamą lygiašonį trikampį .
            7
            77
            777
            7777
            77777
            7777
            777
            77
            7
            */
            //SkaiciuLygiasonisTrikampis();

            /*-----------9a uzduotis----------------
            Parašykite metodą SkaiciuEile kuri išvestu vienoje eilutėje skaičių grupes tokiu principu: -> 1 -> 11 -> 111 -> 1111 -> 11111 -> .......
            programa turi paprašyti nurodyti skaičių ir grupių kiekį
            naudokite for ir StringBuilder
            */
            //SkaiciuEile();

            /*-----------10a uzduotis----------------
            Sukurti metodą DidejanciuSkaiciuStatusTrikampis, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9 jeigu įveda
            netinkamą skaičių prašo įvesti vėl, kol įves tinkamą )). Programa turi atspausdinti
            atitinkamą statųjį trikampį.
            1
            22
            333
            4444
            55555
            */
            //DidejanciuSkaiciuStatusTrikampis();

            /*-----------11a uzduotis----------------
            Sukurti metodą DidejanciuSkaiciuTrikampis, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9 jeigu įveda netinkamą skaičių
            prašo įvesti vėl, kol įves tinkamą )). Programa turi atspausdinti atitinkamą lygiašonį trikampį .
            1
            22
            333
            4444
            333
            22
            1
            */
            //DidejanciuSkaiciuLygiasonisTrikampis();

            /*-----------12a uzduotis----------------
            Sukurti metodą FormulesSprendimas
            Suskaičiuokite formules atsakymą. Ranka įvesti formulės elementus negalima, kode būtina skaidyti string kintamajį
            Matematinio veiksmų eiliškumo galima nesilaikyti.
            formule yra 1 + x + x / 2 + x / 3 + x / 2 + 1 * 2;
            x = 3;
            (teisingas atsakymas yra 7.166 (jei nesilaikoma eiliškumo) arba 10 (jei laikomasi))
            */
            //FormulesSprendimas("1 + x + x / 2 + x / 3 + x / 2 + 1 * 2", 3);

            /*-----------13a uzduotis----------------
            Sukurti metodą Palindromas
            Parašykite programą kuri nustatytu ar įvestas skaičius ar tekstas yra palindromas(skaitant nuo pradžios ir galo yra toks pats)
            pvz 1284821, arba RABAR
            naudokite for ciklą
            */
            //Palindromas();

            /*-----------14a uzduotis----------------
            parašykite programą kuri matricoje 4x4 surastu didžiausią skaičių ir artimiausia prie vidutinio skaičiaus
            9 22 3 19
            6 16 11 8
            7 5 18 10
            8 6 2 11
            */
            MatricosPatikrinimas();


            //----------------------1os uzduoties metodas--------------
            static void ReadIntNumber()
            {
                int naujasSkaicius = 0;            
                int x = 0;
                while (x != 1)
                {
                    Console.WriteLine("Iveskite sveikąjį skaičių");
                    var ivestasSkaicius = Console.ReadLine();
                    if (int.TryParse(ivestasSkaicius, out naujasSkaicius))
                    {
                        Console.WriteLine($"Įvestas skaičius yra {naujasSkaicius}"); 
                        x = 1;
                    }
                    else
                        Console.WriteLine($"neteisingai įvedėte, prašome įvesti sveiką skaičių");

                }
            }

            //----------------------2os uzduoties metodas--------------
            static int TryParseReloaded(string skaicius, out bool tiesa)
            {
                try
                {
                    int konvertuotasSkaicius = Convert.ToInt32(skaicius);
                    Console.WriteLine(konvertuotasSkaicius);
                    tiesa = true;
                    return konvertuotasSkaicius;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Konvertuoti nepavyko");
                    tiesa = false;
                    return 0; 
                }               
            }

            //-------------------3ios uzduoties metodas----------------
            static string IntegerToBinary(string duomenys)
            {
                string rezultatas = string.Empty; //sukuriam tuscia string tipo kintamaji
                int rem = 0; //laikinas kintmasis
                try //bandom parsinti
                {
                    int desimtanisSkaicius = int.Parse(duomenys); //parsinam
                    while (desimtanisSkaicius > 0) //kol skai
                    {
                        rem = desimtanisSkaicius % 2; //dalindami is 2 gaunam liekana 1 arba 0
                        desimtanisSkaicius = desimtanisSkaicius / 2; // susimazinam skaiciu dvigubai
                        rezultatas = rem.ToString() + rezultatas; //formuojam atsakyma
                    }                                                         
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message); //jei nepavyks parsinti ismes klaida su klaidos pavadinimu
                }
                return rezultatas;
            }

            //-------------------4os uzduoties metodas------------------
            static int PakeltiLaipsniu(int skaicius, int laipsnis)
            {
                int rez = 1;
                if (laipsnis == 0)
                {
                    return rez;
                }
                else
                {
                    for (int i = 0; i < laipsnis; i++)
                    {
                        rez = skaicius * rez;
                    }
                    return rez;
                }
               
            }
            
            //-------------------5os uzduoties metodas------------------
            static int BinaryToInteger(string duomenys)
            {
                int rezultatas = 0;
                int eilutesIlgis = duomenys.Length;
                foreach (var item in duomenys)
                {
                    string item1 = Convert.ToString(item);
                    eilutesIlgis = eilutesIlgis - 1;
                    rezultatas = rezultatas + int.Parse(item1) * PakeltiLaipsniu(2, eilutesIlgis);
                }
                return rezultatas;
            }

            //-------------------6os uzduoties metodas------------------
            static void SentenceAnalysis(string tekstas)
            {
                Dictionary<char, int> simboliaiTekste = new Dictionary<char, int>();
                foreach (var simbolis in tekstas)
                {
                    if (simbolis != ' ')
                    {
                        if (simboliaiTekste.ContainsKey(simbolis))
                        {
                            simboliaiTekste[simbolis] += 1;
                        }
                        else
                        {
                            simboliaiTekste.Add(simbolis, 1);
                        }
                    }

                }
                Console.WriteLine($"Sakinio \"{tekstas}\", raidžių analizai:");
                Console.WriteLine(String.Join(" ", simboliaiTekste));

                var maxRaidziuKiekis = simboliaiTekste.Values.Max();
                Console.WriteLine($"Dazniausiai t.y. {maxRaidziuKiekis} kartus pasikartojancios teksto \"{tekstas}\", raides yra:");
                foreach (var raide in simboliaiTekste)
                {
                    if (raide.Value == maxRaidziuKiekis)
                    {
                        Console.WriteLine($"{raide.Key}");
                    }
                }

                var minRaidziuKiekis = simboliaiTekste.Values.Min();
                Console.WriteLine($"Rečiausiai t.y. {minRaidziuKiekis} kartus pasikartojancios teksto \"{tekstas}\", raides yra:");
                foreach (var raide in simboliaiTekste)
                {
                    if (raide.Value == minRaidziuKiekis)
                    {
                        Console.WriteLine($"{raide.Key}");
                    }
                }
            }

            static int PasirinkiteSkaiciu()
            {
                int naujasSkaicius = 0;
                int x = 0;
                while (x != 1)
                {
                    Console.WriteLine("Iveskite sveikąjį skaičių nuo 1 iki 9");
                    var ivestasSkaicius = Console.ReadLine();
                    if (int.TryParse(ivestasSkaicius, out naujasSkaicius))
                    {
                        if (naujasSkaicius >= 1 && naujasSkaicius <= 9)
                        {
                            Console.WriteLine($"Įvestas skaičius yra {naujasSkaicius}");
                            x = 1;
                        }

                    }
                    else
                        Console.WriteLine($"neteisingai įvedėte, prašome įvesti sveiką skaičių nuo 1 iki 9");

                }
                return naujasSkaicius;
            }

            //-------------------7os uzduoties metodas------------------
            static void SkaiciuStatusTrikampis()
            {
                int naujasSkaicius = PasirinkiteSkaiciu();
                string spausdinimui = string.Empty;
                for (int i = 0; i < naujasSkaicius; i++)
                {
                    spausdinimui = spausdinimui + naujasSkaicius;
                    Console.WriteLine(spausdinimui);
                }
            }

            //-------------------8os uzduoties metodas------------------
            static void SkaiciuLygiasonisTrikampis()
            {
                int naujasSkaicius = PasirinkiteSkaiciu();
                string spausdinimui = string.Empty;
                for (int i = 0; i < naujasSkaicius; i++)
                {
                    spausdinimui = spausdinimui + naujasSkaicius;
                    Console.WriteLine(spausdinimui);
                }
                for (int i = 0; i < naujasSkaicius; i++)
                {
                    spausdinimui = spausdinimui.Remove(spausdinimui.Length - 1);
                    Console.WriteLine(spausdinimui);
                }

            }

            //-------------------9os uzduoties metodas------------------
            static void SkaiciuEile()
            {
                int naujasSkaicius = PasirinkiteSkaiciu();
                int grupiuSkaicius = 0;
                int y = 0;
                while (y != 1)
                {
                    Console.WriteLine("Iveskite kiek grupiu noresite matyti");
                    var ivestasGrupiuSkaicius = Console.ReadLine();
                    if (int.TryParse(ivestasGrupiuSkaicius, out grupiuSkaicius))
                    {
                        Console.WriteLine($"Įvestas grupių skaičius yra {grupiuSkaicius}");
                        y = 1;
                        
                    }
                    else
                        Console.WriteLine($"neteisingai įvedėte, prašome įvesti sveiką skaičių");
                }
                string simbolis = Convert.ToString(naujasSkaicius);
                StringBuilder eilute = new StringBuilder();
                for (int i = 0; i < grupiuSkaicius; i++)
                {
                    eilute.Append(simbolis);
                    Console.Write(eilute + "-> ");
                }
                Console.WriteLine();
            }

            //-------------------10os uzduoties metodas------------------
            static void DidejanciuSkaiciuStatusTrikampis()
            {
                int pasirinktasSkaicius = PasirinkiteSkaiciu();
                string spausdinimui = string.Empty;
                StringBuilder s = new StringBuilder();
                int i = 1;
                while (i <= pasirinktasSkaicius)
                {
                    s.Append(i);
                    for (int k = 0; k < i; k++)
                    {
                        Console.Write(s);
                    }
                    i++;
                    s.Clear();
                    Console.WriteLine();
                };     
            }

            //-------------------11os uzduoties metodas------------------
            static void DidejanciuSkaiciuLygiasonisTrikampis()
            {
                int pasirinktasSkaicius = PasirinkiteSkaiciu();
                string spausdinimui = string.Empty;
                StringBuilder s = new StringBuilder();
                int i = 1;
                while (i <= pasirinktasSkaicius)
                {
                    s.Append(i);
                    for (int k = 0; k < i; k++)
                    {
                        Console.Write(s);
                    }
                    s.Clear();
                    Console.WriteLine();
                    i++;
                };
                int j = pasirinktasSkaicius-1;
                int g = 0;
                while (j > 0)
                {
                    for (int l = pasirinktasSkaicius-1-g; l > 0; l--)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine();
                    j--;
                    g++;
                }
            }

            //-------------------12os uzduoties metodas------------------
            static void FormulesSprendimas(string formule, int x)
            {
                StringBuilder s = new StringBuilder();
                int kintmasis = x; 
                int i = 0;
                List<int> skaiciukai = new List<int> { };
                var zenkliukai = formule.Split(' ').ToList();

                //1 + x + x / 2 + x / 3 + x / 2 + 1 * 2
                //Console.WriteLine($"Formule pries istatant x reiksme: {string.Join(" ", zenkliukai)}");

                for (int j = 0; j < zenkliukai.Count; j++)
                {
                    if (zenkliukai[j] == "x")
                    {
                        zenkliukai[j] = kintmasis.ToString();
                    }
                }
                
                //Console.WriteLine($"Formule po x reiskmes istatymo {string.Join(" ", zenkliukai)}");

                for (int j = 0; j < zenkliukai.Count; j++) //susikuriam nauja skaiciu lista
                {
                    if (int.TryParse(zenkliukai[j], out int skaicius))
                    {
                        skaiciukai.Add(skaicius);
                    }
                    else skaiciukai.Add(0);
                }

                //Console.WriteLine($"Skaiciu listas {string.Join(" ", skaiciukai)}");

                double rezultatas = 0.0;
                for (int k = 0; k < zenkliukai.Count; k++)
                {
                    if (zenkliukai[k] == "/")
                    {
                        
                        rezultatas = rezultatas + Convert.ToDouble(skaiciukai[k - 1]) / Convert.ToDouble(skaiciukai[k + 1]);
                        //Console.WriteLine($"skaiciaus{skaiciukai[k-1]} dalyba is skaiciaus {skaiciukai[k+1]} rezultatas yra {rezultatas}");
                        k = k + 2;
                    }
                    else
                    {
                        if (zenkliukai[k] == "*")
                        {
                            rezultatas = rezultatas + Convert.ToDouble(skaiciukai[k - 1]) * Convert.ToDouble(skaiciukai[k + 1]);
                            //Console.WriteLine($"skaiciaus{skaiciukai[k - 1]} daugyba is skaiciaus {skaiciukai[k + 1]} rezultatas yra {rezultatas}");
                            k = k + 2;
                        }
                        else
                        {
                            if (zenkliukai[k] == "+")
                            {
                                rezultatas = rezultatas + skaiciukai[k - 1] + skaiciukai[k + 1];
                                //Console.WriteLine(rezultatas);
                                k = k + 2;
                            }
                        }
                    } 
                }
                Console.WriteLine($"formules \"{formule}\", sprendinys, kur x = {x} yra {rezultatas}");
            }

            //-------------------13os uzduoties metodas------------------
            static void Palindromas()
            {
                Console.WriteLine("Iveskite sveika palindromini skaiciu arba teksta");
                var ivestasTekstas = Console.ReadLine();
                List<char> zenkliukai = new List<char> { };
                List<char> apverstiZenkliukai = new List<char> { };

                foreach (var item in ivestasTekstas)
                {
                    zenkliukai.Add(item);
                }

                foreach (var item in ivestasTekstas)
                {
                    apverstiZenkliukai.Add(item);
                }
                apverstiZenkliukai.Reverse();
                bool palindromas = false;

                for (int i = 0; i < ivestasTekstas.Length; i++)
                {
                   if (zenkliukai[i] != apverstiZenkliukai[i])
                    {
                        palindromas = false;
                    }
                   else
                    {
                        palindromas = true;
                    }
                }
                if (palindromas == true)
                {
                    Console.WriteLine($"Ivestas tekstas arba skaicius {ivestasTekstas} yra Palindromas");
                }
                else
                {
                    Console.WriteLine($"Ivestas tekstas arba skaicius {ivestasTekstas} nera Palindromas");
                }

            }

            //-------------------14os uzduoties metodas------------------
            static void MatricosPatikrinimas()
            {
                int[,] matrica = new int[4, 4] { { 9, 22, 3, 19, }, { 6, 16, 11, 8, }, { 7, 5, 18, 10, }, { 8, 6, 2, 11, } };
                int rows = matrica.GetLength(0);
                int cols = matrica.GetLength(1);
                List<int> skaiciukai = new List<int> { };
                List<double> vidurkioSkirtumas = new List<double> { };
                Dictionary<double, byte> skaiciukuSkirtumas = new Dictionary<double, byte> { };
                int suma = 0;
                double vidurkis = 0.0;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        skaiciukai.Add(matrica[i, j]);
                        suma = suma + matrica[i, j];
                    }
                }
                var sumaDouble = Convert.ToDouble(suma);
                vidurkis = sumaDouble / (rows * cols);
                for (int i = 0; i < skaiciukai.Count; i++)
                {
                    if (skaiciukai[i] >= vidurkis)
                    {
                        vidurkioSkirtumas.Add(skaiciukai[i] - vidurkis + 0.01);
                    }
                    else
                    {
                        vidurkioSkirtumas.Add(vidurkis - skaiciukai[i]);
                    }
                }
                double artimiausias = 0.0; 
                if (vidurkioSkirtumas.Min() % 1 == 0.01)
                {
                    artimiausias = vidurkis + vidurkioSkirtumas.Min() - 0.01;
                }
                else
                {
                    artimiausias =  vidurkis - vidurkioSkirtumas.Min();
                }              

                Console.WriteLine($"Matricos nariu suma lygi {suma}, vidurkis {vidurkis}, maximalus {skaiciukai.Max()}, artimiausias vidurkiui {artimiausias}");
                
            }

        }
    }
}
