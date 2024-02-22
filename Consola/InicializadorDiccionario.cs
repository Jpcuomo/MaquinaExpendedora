using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class InicializadorDiccionario
    {

        public static Dictionary<short, Stack<Producto>> InicializarDiccionario()
        {
            Dictionary<short, Stack<Producto>> maquinaExpendedora = new Dictionary<short, Stack<Producto>>();

            // Agua mineral
            Producto aguaVillavicencio1 = new Producto("Agua VillaVicencio", 4.75M, "AG001");
            Producto aguaVillavicencio2 = new Producto("Agua VillaVicencio", 4.75M, "AG002");
            Producto aguaVillavicencio3 = new Producto("Agua VillaVicencio", 4.75M, "AG003");
            Stack<Producto> pilaAgua = new Stack<Producto>();
            pilaAgua.Push(aguaVillavicencio1);
            pilaAgua.Push(aguaVillavicencio2);
            pilaAgua.Push(aguaVillavicencio3);

            // Coca-Cola
            Producto cocaCola1 = new Producto("Coca-cola", 30.5M, "CO001");
            Producto cocaCola2 = new Producto("Coca-cola", 30.5M, "CO002");
            Producto cocaCola3 = new Producto("Coca-cola", 30.5M, "CO003");
            Producto cocaCola4 = new Producto("Coca-cola", 30.5M, "CO004");
            Stack<Producto> pilaCoca = new Stack<Producto>();
            pilaCoca.Push(cocaCola1);
            pilaCoca.Push(cocaCola2);
            pilaCoca.Push(cocaCola3);
            pilaCoca.Push(cocaCola4);

            // Fanta
            Producto Fanta1 = new Producto("Fanta", 35.5M, "FA001");
            Producto Fanta2 = new Producto("Fanta", 35.5M, "FA002");
            Producto Fanta3 = new Producto("Fanta", 35.5M, "FA003");
            Producto Fanta4 = new Producto("Fanta", 35.5M, "FA004");
            Stack<Producto> pilaFanta = new Stack<Producto>();
            pilaFanta.Push(Fanta1);
            pilaFanta.Push(Fanta2);
            pilaFanta.Push(Fanta3);
            pilaFanta.Push(Fanta4);

            // Chips Ahoy
            Producto chipsAhoy1 = new Producto("Chips Ahoy", 3.75M, "CA001");
            Producto chipsAhoy2 = new Producto("Chips Ahoy", 3.75M, "CA002");
            Producto chipsAhoy3 = new Producto("Chips Ahoy", 3.75M, "CA003");
            Stack<Producto> pilaChipsAhoy = new Stack<Producto>();
            pilaChipsAhoy.Push(chipsAhoy1);
            pilaChipsAhoy.Push(chipsAhoy2);
            pilaChipsAhoy.Push(chipsAhoy3);

            // Chipsy
            Producto chipsy1 = new Producto("Chipsy", 3.5M, "CH001");
            Producto chipsy2 = new Producto("Chipsy", 3.5M, "CH002");
            Producto chipsy3 = new Producto("Chipsy", 3.5M, "CH003");
            Stack<Producto> pilaChipsy = new Stack<Producto>();
            pilaChipsy.Push(chipsy1);
            pilaChipsy.Push(chipsy2);
            pilaChipsy.Push(chipsy3);

            // Coco Nice
            Producto cocoNice1 = new Producto("Coco Nice", 5.5M, "CN001");
            Producto cocoNice2 = new Producto("Coco Nice", 5.5M, "CN002");
            Producto cocoNice3 = new Producto("Coco Nice", 5.5M, "CN003");
            Producto cocoNice4 = new Producto("Coco Nice", 5.5M, "CN004");
            Stack<Producto> pilaCocoNice = new Stack<Producto>();
            pilaCocoNice.Push(cocoNice1);
            pilaCocoNice.Push(cocoNice2);
            pilaCocoNice.Push(cocoNice3);
            pilaCocoNice.Push(cocoNice4);

            // Energy++
            Producto energy1 = new Producto("Energy++", 2.5M, "EN001");
            Producto energy2 = new Producto("Energy++", 2.5M, "EN002");
            Producto energy3 = new Producto("Energy++", 2.5M, "EN003");
            Producto energy4 = new Producto("Energy++", 2.5M, "EN004");
            Stack<Producto> pilaEnergy = new Stack<Producto>();
            pilaEnergy.Push(energy1);
            pilaEnergy.Push(energy2);
            pilaEnergy.Push(energy3);
            pilaEnergy.Push(energy4);

            // Memory Vita
            Producto mVita1 = new Producto("Memory Vita", 2.2M, "MV001");
            Producto mVita2 = new Producto("Memory Vita", 2.2M, "MV002");
            Producto mVita3 = new Producto("Memory Vita", 2.2M, "MV003");
            Producto mVita4 = new Producto("Memory Vita", 2.2M, "MV004");
            Stack<Producto> pilaMVita = new Stack<Producto>();
            pilaMVita.Push(mVita1);
            pilaMVita.Push(mVita2);
            pilaMVita.Push(mVita3);
            pilaMVita.Push(mVita4);

            // Nairn´s
            Producto nairn1 = new Producto("Nairn´s", 6.5M, "NA001");
            Producto nairn2 = new Producto("Nairn´s", 6.5M, "NA002");
            Producto nairn3 = new Producto("Nairn´s", 6.5M, "NA003");
            Stack<Producto> pilaNairns = new Stack<Producto>();
            pilaNairns.Push(nairn1);
            pilaNairns.Push(nairn2);
            pilaNairns.Push(nairn3);

            // Milk
            Producto milk1 = new Producto("Milk", 10M, "MK001");
            Producto milk2 = new Producto("Milk", 10M, "MK002");
            Producto milk3 = new Producto("Milk", 10M, "MK003");
            Producto milk4 = new Producto("Milk", 10M, "MK004");
            Stack<Producto> pilaMilk = new Stack<Producto>();
            pilaMilk.Push(milk1);
            pilaMilk.Push(milk2);
            pilaMilk.Push(milk3);
            pilaMilk.Push(milk4);

            // Oreo
            Producto oreo1 = new Producto("Oreo", 1.5M, "OR001");
            Producto oreo2 = new Producto("Oreo", 1.5M, "OR002");
            Producto oreo3 = new Producto("Oreo", 1.5M, "OR003");
            Producto oreo4 = new Producto("Oreo", 1.5M, "OR004");
            Stack<Producto> pilaOreo = new Stack<Producto>();
            pilaOreo.Push(oreo1);
            pilaOreo.Push(oreo2);
            pilaOreo.Push(oreo3);
            pilaOreo.Push(oreo4);

            // Pepsi
            Producto Pepsi1 = new Producto("Pepsi", 40.5M, "PE001");
            Producto Pepsi2 = new Producto("Pepsi", 40.5M, "PE002");
            Producto Pepsi3 = new Producto("Pepsi", 40.5M, "PE003");
            Producto Pepsi4 = new Producto("Pepsi", 40.5M, "PE004");
            Stack<Producto> pilaPepsi = new Stack<Producto>();
            pilaPepsi.Push(Pepsi1);
            pilaPepsi.Push(Pepsi2);
            pilaPepsi.Push(Pepsi3);
            pilaPepsi.Push(Pepsi4);

            // Chips Rubio
            Producto chipsRubio1 = new Producto("Chips Rubio", 3.7M, "CR001");
            Producto chipsRubio2 = new Producto("Chips Rubio", 3.7M, "CR002");
            Producto chipsRubio3 = new Producto("Chips Rubio", 3.7M, "CR003");
            Stack<Producto> pilaChipsRubio = new Stack<Producto>();
            pilaChipsRubio.Push(chipsRubio1);
            pilaChipsRubio.Push(chipsRubio2);
            pilaChipsRubio.Push(chipsRubio3);

            // Snickers
            Producto snickers1 = new Producto("Snickers", 5M, "SN001");
            Producto snickers2 = new Producto("Snickers", 5M, "SN002");
            Producto snickers3 = new Producto("Snickers", 5M, "SN003");
            Stack<Producto> pilaSnickers = new Stack<Producto>();
            pilaSnickers.Push(snickers1);
            pilaSnickers.Push(snickers2);
            pilaSnickers.Push(snickers3);

            // Extraordinarias
            Producto extraordinarias1 = new Producto("Extraordinarias", 4M, "ES001");
            Producto extraordinarias2 = new Producto("Extraordinarias", 4M, "ES002");
            Producto extraordinarias3 = new Producto("Extraordinarias", 4M, "ES003");
            Stack<Producto> pilaExtraordinarias = new Stack<Producto>();
            pilaExtraordinarias.Push(extraordinarias1);
            pilaExtraordinarias.Push(extraordinarias2);
            pilaExtraordinarias.Push(extraordinarias3);

            // Skittles
            Producto skittles1 = new Producto("Skittles", 3M, "SK001");
            Producto skittles2 = new Producto("Skittles", 3M, "SK002");
            Producto skittles3 = new Producto("Skittles", 3M, "SK003");
            Stack<Producto> pilaSkittles = new Stack<Producto>();
            pilaSkittles.Push(skittles1);
            pilaSkittles.Push(skittles2);
            pilaSkittles.Push(skittles3);

            // Llenado de diccionario
            maquinaExpendedora[1] = pilaAgua;
            maquinaExpendedora[2] = pilaCoca;
            maquinaExpendedora[3] = pilaFanta;
            maquinaExpendedora[4] = pilaChipsAhoy;
            maquinaExpendedora[5] = pilaChipsy;
            maquinaExpendedora[6] = pilaCocoNice;
            maquinaExpendedora[7] = pilaEnergy;
            maquinaExpendedora[8] = pilaMVita;
            maquinaExpendedora[9] = pilaNairns;
            maquinaExpendedora[10] = pilaMilk;
            maquinaExpendedora[11] = pilaOreo;
            maquinaExpendedora[12] = pilaPepsi;
            maquinaExpendedora[13] = pilaChipsRubio;
            maquinaExpendedora[14] = pilaSnickers;
            maquinaExpendedora[15] = pilaExtraordinarias;
            maquinaExpendedora[16] = pilaSkittles;

            return maquinaExpendedora;
        }
    }
}
