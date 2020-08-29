using System;
using System.Collections.Generic;
using System.Linq;

namespace Monochampions_list
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, int> champdict = new Dictionary<string, int>();
			champdict.Add("karthus", 2941);
			champdict.Add("skarner", 2208);
			champdict.Add("hecarim", 1700);
			champdict.Add("swain", 1568);
			champdict.Add("urgot", 1559);
			champdict.Add("rammus", 1502);
			champdict.Add("nunu", 1467);
			champdict.Add("zilean", 1395);
			champdict.Add("udyr", 1316);
			champdict.Add("singed", 1220);
			champdict.Add("annie", 1016);
			champdict.Add("kog'maw", 953);
			champdict.Add("heimerdinger", 710);
			champdict.Add("aurelionsol", 694);
			champdict.Add("ivern", 630);
			champdict.Add("quinn", 626);
			champdict.Add("shyvanna", 603);
			champdict.Add("tahmkench", 600);
			champdict.Add("yorick", 555);
			champdict.Add("fiddlesticks", 514);
			champdict.Add("dr.mundo", 450);
			champdict.Add("evelynn", 442);
			champdict.Add("warwick", 417);
			champdict.Add("rengar", 353);
			champdict.Add("cho'gath", 324);
			champdict.Add("nasus", 314);
			champdict.Add("rek'sai", 283);
			champdict.Add("vi", 259);
			champdict.Add("kled", 254);
			champdict.Add("taliyah", 175);
			champdict.Add("amumu", 169);
			champdict.Add("kayle", 163);
			champdict.Add("garen", 160);
			champdict.Add("tryndamere", 158);
			champdict.Add("azir", 135);
			champdict.Add("ziggs", 134);
			champdict.Add("wukong", 133);
			champdict.Add("lissandra", 125);
			champdict.Add("anivia", 102);
			champdict.Add("olaf", 101);
			champdict.Add("braum", 100);
			champdict.Add("galio", 99);
			champdict.Add("poppy", 94);
			champdict.Add("xinzhao", 90);
			champdict.Add("zac", 84);
			champdict.Add("rumble", 80);
			champdict.Add("sion", 71);
			champdict.Add("illaoi", 67);
			champdict.Add("khazix", 50);
			champdict.Add("masteryi", 20);

			List<String> champdictio = new List<string>();
			champdictio.Add("karthus");
			champdictio.Add("skarner");
			champdictio.Add("hecarim");
			champdictio.Add("swain");
			champdictio.Add("urgot");
			champdictio.Add("rammus");
			champdictio.Add("nunu");
			champdictio.Add("zilean");
			champdictio.Add("udyr");
			champdictio.Add("singed");
			champdictio.Add("annie");
			champdictio.Add("kog'maw");
			champdictio.Add("heimerdinger");
			champdictio.Add("aurelionsol");
			champdictio.Add("ivern");
			champdictio.Add("quinn");
			champdictio.Add("shyvanna");
			champdictio.Add("tahmkench");
			champdictio.Add("yorick");
			champdictio.Add("fiddlesticks");
			champdictio.Add("dr.mundo");
			champdictio.Add("evelynn");
			champdictio.Add("warwick");
			champdictio.Add("rengar");
			champdictio.Add("cho'gath");
			champdictio.Add("nasus");
			champdictio.Add("rek'sai");
			champdictio.Add("vi");
			champdictio.Add("kled");
			champdictio.Add("taliyah");
			champdictio.Add("amumu");
			champdictio.Add("kayle");
			champdictio.Add("garen");
			champdictio.Add("tryndamere");
			champdictio.Add("azir");
			champdictio.Add("ziggs");
			champdictio.Add("wukong");
			champdictio.Add("lissandra");
			champdictio.Add("anivia");
			champdictio.Add("olaf");
			champdictio.Add("braum");
			champdictio.Add("galio");
			champdictio.Add("poppy");
			champdictio.Add("xinzhao");
			champdictio.Add("zac");
			champdictio.Add("rumble");
			champdictio.Add("sion");
			champdictio.Add("illaoi");
			champdictio.Add("khazix");
			champdictio.Add("masteryi");

			int[,] championsRole = new int[100000, 5];
			championsRole[champdict["karthus"], 0] = 1;
			championsRole[champdict["karthus"], 1] = 1;
			championsRole[champdict["karthus"], 2] = 1;
			championsRole[champdict["karthus"], 3] = 1;
			championsRole[champdict["karthus"], 4] = 2;
			championsRole[champdict["skarner"], 0] = 1;
			championsRole[champdict["skarner"], 4] = 2;
			championsRole[champdict["hecarim"], 0] = 1;
			championsRole[champdict["hecarim"], 4] = 2;
			championsRole[champdict["swain"], 0] = 1;
			championsRole[champdict["swain"], 1] = 2;
			championsRole[champdict["swain"], 2] = 1;
			championsRole[champdict["swain"], 3] = 1;
			championsRole[champdict["urgot"], 0] = 2;
			championsRole[champdict["urgot"], 1] = 1;
			championsRole[champdict["rammus"], 0] = 1;
			championsRole[champdict["rammus"], 4] = 2;
			championsRole[champdict["nunu"], 1] = 1;
			championsRole[champdict["nunu"], 4] = 2;
			championsRole[champdict["zilean"], 1] = 1;
			championsRole[champdict["zilean"], 3] = 2;
			championsRole[champdict["udyr"], 4] = 2;
			championsRole[champdict["singed"], 0] = 2;
			championsRole[champdict["annie"], 0] = 1;
			championsRole[champdict["annie"], 1] = 2;
			championsRole[champdict["annie"], 3] = 1;
			championsRole[champdict["kog'maw"], 0] = 1;
			championsRole[champdict["kog'maw"], 1] = 1;
			championsRole[champdict["kog'maw"], 3] = 2;
			championsRole[champdict["heimerdinger"], 0] = 1;
			championsRole[champdict["heimerdinger"], 1] = 2;
			championsRole[champdict["heimerdinger"], 3] = 1;
			championsRole[champdict["aurelionsol"], 0] = 1;
			championsRole[champdict["aurelionsol"], 1] = 2;
			championsRole[champdict["ivern"], 0] = 1;
			championsRole[champdict["ivern"], 3] = 1;
			championsRole[champdict["ivern"], 4] = 2;
			championsRole[champdict["quinn"], 0] = 1;
			championsRole[champdict["quinn"], 1] = 2;
			championsRole[champdict["shyvanna"], 0] = 1;
			championsRole[champdict["shyvanna"], 4] = 2;
			championsRole[champdict["tahmkench"], 0] = 2;
			championsRole[champdict["tahmkench"], 3] = 1;
			championsRole[champdict["yorick"], 0] = 2;
			championsRole[champdict["fiddlesticks"], 0] = 1;
			championsRole[champdict["fiddlesticks"], 1] = 1;
			championsRole[champdict["fiddlesticks"], 3] = 1;
			championsRole[champdict["fiddlesticks"], 4] = 2;
			championsRole[champdict["dr.mundo"], 0] = 2;
			championsRole[champdict["dr.mundo"], 4] = 1;
			championsRole[champdict["evelynn"], 4] = 2;
			championsRole[champdict["rengar"], 0] = 2;
			championsRole[champdict["rengar"], 4] = 1;
			championsRole[champdict["cho'gath"], 0] = 1;
			championsRole[champdict["cho'gath"], 1] = 2;
			championsRole[champdict["cho'gath"], 3] = 1;
			championsRole[champdict["cho'gath"], 4] = 1;
			championsRole[champdict["nasus"], 0] = 1;
			championsRole[champdict["nasus"], 1] = 1;
			championsRole[champdict["rek'sai"], 0] = 1;
			championsRole[champdict["rek'sai"], 4] = 2;
			championsRole[champdict["vi"], 4] = 2;
			championsRole[champdict["kled"], 0] = 1;
			championsRole[champdict["kled"], 1] = 1;
			championsRole[champdict["taliyah"], 1] = 1;
			championsRole[champdict["taliyah"], 3] = 1;
			championsRole[champdict["taliyah"], 4] = 1;
			championsRole[champdict["amumu"], 3] = 1;
			championsRole[champdict["amumu"], 4] = 2;
			championsRole[champdict["kayle"], 0] = 2;
			championsRole[champdict["kayle"], 1] = 1;
			championsRole[champdict["garen"], 0] = 2;
			championsRole[champdict["garen"], 1] = 1;
			championsRole[champdict["tryndamere"], 0] = 2;
			championsRole[champdict["tryndamere"], 1] = 1;
			championsRole[champdict["tryndamere"], 4] = 1;
			championsRole[champdict["azir"], 0] = 1;
			championsRole[champdict["azir"], 1] = 2;
			championsRole[champdict["ziggs"], 0] = 1;
			championsRole[champdict["ziggs"], 1] = 2;
			championsRole[champdict["ziggs"], 3] = 1;
			championsRole[champdict["wukong"], 0] = 1;
			championsRole[champdict["wukong"], 2] = 1;
			championsRole[champdict["wukong"], 4] = 2;
			championsRole[champdict["lissandra"], 0] = 1;
			championsRole[champdict["lissandra"], 2] = 2;
			championsRole[champdict["anivia"], 2] = 2;
			championsRole[champdict["olaf"], 0] = 1;
			championsRole[champdict["olaf"], 4] = 2;
			championsRole[champdict["braum"], 3] = 2;
			championsRole[champdict["galio"], 2] = 2;
			championsRole[champdict["galio"], 3] = 1;
			championsRole[champdict["poppy"], 0] = 2;
			championsRole[champdict["poppy"], 3] = 1;
			championsRole[champdict["poppy"], 4] = 1;
			championsRole[champdict["xinzhao"], 0] = 1;
			championsRole[champdict["xinzhao"], 2] = 1;
			championsRole[champdict["zac"], 0] = 1;
			championsRole[champdict["zac"], 3] = 1;
			championsRole[champdict["zac"], 4] = 2;
			championsRole[champdict["rumble"], 0] = 1;
			championsRole[champdict["rumble"], 2] = 2;
			championsRole[champdict["sion"], 0] = 2;
			championsRole[champdict["sion"], 2] = 1;
			championsRole[champdict["sion"], 3] = 1;
			championsRole[champdict["sion"], 4] = 1;
			championsRole[champdict["illaoi"], 0] = 2;
			championsRole[champdict["illaoi"], 2] = 1;
			championsRole[champdict["khazix"], 4] = 2;
			championsRole[champdict["masteryi"], 0] = 1;
			championsRole[champdict["masteryi"], 4] = 2;

			Console.WriteLine("BRONZE:");
			string[] enterchamp = Console.ReadLine().Split(" ");

		;
			int[] champScore = new int[10];
			for(int i = 0; i < 10; i++)
			{
				champScore[i] = champdict[enterchamp[i]];
			}

			int[] champtopmain = new int[10];
			int[] champtop = new int[10];
			int contador = 0;
			for (int i = 0; i < 10; i++)
			{	
				if (championsRole[champScore[i], 0] == 2)
				{
					champtopmain[i] = contador + 1;
					contador += 1;
				}
			}
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 0] == 1)
				{
					champtop[i] = contador + 1;
					Console.WriteLine(champScore[i]);
					Console.WriteLine(champtop[i]);
					contador += 1;
				}
			}

			int divisor = 0;
			int notMains = 0;
			if (champtop[0] > 0 || champtopmain[0] > 0) { divisor += 1; }
			if (champtop[1] > 0 || champtopmain[1] > 0) { divisor += 1; }
			if (champtop[2] > 0 || champtopmain[2] > 0) { divisor += 1; }
			if (champtop[3] > 0 || champtopmain[3] > 0) { divisor += 1; }
			if (champtop[4] > 0 || champtopmain[4] > 0) { divisor += 1; }
			if (champtop[5] > 0 || champtopmain[5] > 0) { divisor += 1; }
			if (champtop[6] > 0 || champtopmain[6] > 0) { divisor += 1; }
			if (champtop[7] > 0 || champtopmain[7] > 0) { divisor += 1; }
			if (champtop[8] > 0 || champtopmain[8] > 0) { divisor += 1; }
			if (champtop[9] > 0 || champtopmain[9] > 0) { divisor += 1; }

			if (champtop[0] > 0) { notMains += 1; }
			if (champtop[1] > 0) { notMains += 1; }
			if (champtop[2] > 0) { notMains += 1; }
			if (champtop[3] > 0) { notMains += 1; }
			if (champtop[4] > 0) { notMains += 1; }
			if (champtop[5] > 0) { notMains += 1; }
			if (champtop[6] > 0) { notMains += 1; }
			if (champtop[7] > 0) { notMains += 1; }
			if (champtop[8] > 0) { notMains += 1; }
			if (champtop[9] > 0) { notMains += 1; }

			for (int i = 0; i < 10; i++)
			{
				if (champtopmain[i] == 1) { champdict[enterchamp[i]] += 100; }
				if (champtopmain[i] == 2) { champdict[enterchamp[i]] += 100 * (divisor - 1) / divisor; }
				if (champtopmain[i] == 3) { champdict[enterchamp[i]] += 100 * (divisor - 2) / divisor; }
				if (champtopmain[i] == 4) { champdict[enterchamp[i]] += 100 * (divisor - 3) / divisor; }
				if (champtopmain[i] == 5) { champdict[enterchamp[i]] += 100 * (divisor - 4) / divisor; }
				if (champtopmain[i] == 6) { champdict[enterchamp[i]] += 100 * (divisor - 5) / divisor; }
				if (champtopmain[i] == 7) { champdict[enterchamp[i]] += 100 * (divisor - 6) / divisor; }
				if (champtopmain[i] == 8) { champdict[enterchamp[i]] += 100 * (divisor - 7) / divisor; }
				if (champtopmain[i] == 9) { champdict[enterchamp[i]] += 100 * (divisor - 8) / divisor; }
				if (champtopmain[i] == 10) { champdict[enterchamp[i]] += 100 * (divisor - 9) / divisor; }
			}
			for (int i = 0; i < 10; i++)
			{
				if (champtop[i] == divisor-notMains+1) { champdict[enterchamp[i]] += ((divisor-(divisor-notMains))*100) / divisor; }
				if (champtop[i] == divisor-notMains+2) { champdict[enterchamp[i]] += ((divisor-(divisor-notMains))*100-100) / divisor; }
				if (champtop[i] == divisor-notMains+3) { champdict[enterchamp[i]] += ((divisor-(divisor-notMains))*100-200) / divisor; }
				if (champtop[i] == divisor-notMains+4) { champdict[enterchamp[i]] += ((divisor-(divisor-notMains))*100-300) / divisor; }
				if (champtop[i] == divisor-notMains+5) { champdict[enterchamp[i]] += ((divisor-(divisor-notMains))*100-400) / divisor; }
				if (champtop[i] == divisor-notMains+6) { champdict[enterchamp[i]] += ((divisor-(divisor-notMains))*100-500) / divisor; }
				if (champtop[i] == divisor-notMains+7) { champdict[enterchamp[i]] += ((divisor-(divisor-notMains))*100-600) / divisor; }
				if (champtop[i] == divisor-notMains+8) { champdict[enterchamp[i]] += ((divisor-(divisor-notMains))*100-700) / divisor; }
				if (champtop[i] == divisor-notMains+9) { champdict[enterchamp[i]] += ((divisor-(divisor-notMains))*100-800) / divisor; }
				if (champtop[i] == divisor-notMains+10) { champdict[enterchamp[i]] += ((divisor-(divisor-notMains))*100-900) / divisor; }
			}

			int[] champmidmain = new int[10];
			int[] champmid = new int[10];
			contador = 0;
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 1] == 2)
				{
					champmidmain[i] = contador + 1;
					contador += 1;
				}
			}
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 1] == 1)
				{
					champmid[i] = contador + 1;
					contador += 1;
				}
			}

			divisor = 0;
			notMains = 0;
			if (champmid[0] > 0 || champmidmain[0] > 0) { divisor += 1; }
			if (champmid[1] > 0 || champmidmain[1] > 0) { divisor += 1; }
			if (champmid[2] > 0 || champmidmain[2] > 0) { divisor += 1; }
			if (champmid[3] > 0 || champmidmain[3] > 0) { divisor += 1; }
			if (champmid[4] > 0 || champmidmain[4] > 0) { divisor += 1; }
			if (champmid[5] > 0 || champmidmain[5] > 0) { divisor += 1; }
			if (champmid[6] > 0 || champmidmain[6] > 0) { divisor += 1; }
			if (champmid[7] > 0 || champmidmain[7] > 0) { divisor += 1; }
			if (champmid[8] > 0 || champmidmain[8] > 0) { divisor += 1; }
			if (champmid[9] > 0 || champmidmain[9] > 0) { divisor += 1; }

			if (champmid[0] > 0) { notMains += 1; }
			if (champmid[1] > 0) { notMains += 1; }
			if (champmid[2] > 0) { notMains += 1; }
			if (champmid[3] > 0) { notMains += 1; }
			if (champmid[4] > 0) { notMains += 1; }
			if (champmid[5] > 0) { notMains += 1; }
			if (champmid[6] > 0) { notMains += 1; }
			if (champmid[7] > 0) { notMains += 1; }
			if (champmid[8] > 0) { notMains += 1; }
			if (champmid[9] > 0) { notMains += 1; }

			for (int i = 0; i < 10; i++)
			{
				if (champmidmain[i] == 1) { champdict[enterchamp[i]] += 100; }
				if (champmidmain[i] == 2) { champdict[enterchamp[i]] += 100 * (divisor - 1) / divisor; }
				if (champmidmain[i] == 3) { champdict[enterchamp[i]] += 100 * (divisor - 2) / divisor; }
				if (champmidmain[i] == 4) { champdict[enterchamp[i]] += 100 * (divisor - 3) / divisor; }
				if (champmidmain[i] == 5) { champdict[enterchamp[i]] += 100 * (divisor - 4) / divisor; }
				if (champmidmain[i] == 6) { champdict[enterchamp[i]] += 100 * (divisor - 5) / divisor; }
				if (champmidmain[i] == 7) { champdict[enterchamp[i]] += 100 * (divisor - 6) / divisor; }
				if (champmidmain[i] == 8) { champdict[enterchamp[i]] += 100 * (divisor - 7) / divisor; }
				if (champmidmain[i] == 9) { champdict[enterchamp[i]] += 100 * (divisor - 8) / divisor; }
				if (champmidmain[i] == 10) { champdict[enterchamp[i]] += 100 * (divisor - 9) / divisor; }
			}
			for (int i = 0; i < 10; i++)
			{
				if (champmid[i] == divisor - notMains + 1) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100) / divisor; }
				if (champmid[i] == divisor - notMains + 2) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 100) / divisor; }
				if (champmid[i] == divisor - notMains + 3) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 200) / divisor; }
				if (champmid[i] == divisor - notMains + 4) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 300) / divisor; }
				if (champmid[i] == divisor - notMains + 5) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 400) / divisor; }
				if (champmid[i] == divisor - notMains + 6) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 500) / divisor; }
				if (champmid[i] == divisor - notMains + 7) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 600) / divisor; }
				if (champmid[i] == divisor - notMains + 8) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 700) / divisor; }
				if (champmid[i] == divisor - notMains + 9) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 800) / divisor; }
				if (champmid[i] == divisor - notMains + 10) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 900) / divisor; }
		}


			int[] champadcmain = new int[10];
			int[] champadc = new int[10];
			contador = 0;
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 2] == 2)
				{
					champadcmain[i] = contador + 1;
					contador += 1;
				}
			}
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 2] == 1)
				{
					champadc[i] = contador + 1;
					contador += 1;
				}
			}

			divisor = 0;
			notMains = 0;
			if (champadc[0] > 0 || champadcmain[0] > 0) { divisor += 1; }
			if (champadc[1] > 0 || champadcmain[1] > 0) { divisor += 1; }
			if (champadc[2] > 0 || champadcmain[2] > 0) { divisor += 1; }
			if (champadc[3] > 0 || champadcmain[3] > 0) { divisor += 1; }
			if (champadc[4] > 0 || champadcmain[4] > 0) { divisor += 1; }
			if (champadc[5] > 0 || champadcmain[5] > 0) { divisor += 1; }
			if (champadc[6] > 0 || champadcmain[6] > 0) { divisor += 1; }
			if (champadc[7] > 0 || champadcmain[7] > 0) { divisor += 1; }
			if (champadc[8] > 0 || champadcmain[8] > 0) { divisor += 1; }
			if (champadc[9] > 0 || champadcmain[9] > 0) { divisor += 1; }

			if (champadc[0] > 0) { notMains += 1; }
			if (champadc[1] > 0) { notMains += 1; }
			if (champadc[2] > 0) { notMains += 1; }
			if (champadc[3] > 0) { notMains += 1; }
			if (champadc[4] > 0) { notMains += 1; }
			if (champadc[5] > 0) { notMains += 1; }
			if (champadc[6] > 0) { notMains += 1; }
			if (champadc[7] > 0) { notMains += 1; }
			if (champadc[8] > 0) { notMains += 1; }
			if (champadc[9] > 0) { notMains += 1; }

			
			
			for (int i = 0; i < 10; i++)
			{
				if (champadcmain[i] == 1) { champdict[enterchamp[i]] += 100; }
				if (champadcmain[i] == 2) { champdict[enterchamp[i]] += 100 * (divisor - 1) / divisor; }
				if (champadcmain[i] == 3) { champdict[enterchamp[i]] += 100 * (divisor - 2) / divisor; }
				if (champadcmain[i] == 4) { champdict[enterchamp[i]] += 100 * (divisor - 3) / divisor; }
				if (champadcmain[i] == 5) { champdict[enterchamp[i]] += 100 * (divisor - 4) / divisor; }
				if (champadcmain[i] == 6) { champdict[enterchamp[i]] += 100 * (divisor - 5) / divisor; }
				if (champadcmain[i] == 7) { champdict[enterchamp[i]] += 100 * (divisor - 6) / divisor; }
				if (champadcmain[i] == 8) { champdict[enterchamp[i]] += 100 * (divisor - 7) / divisor; }
				if (champadcmain[i] == 9) { champdict[enterchamp[i]] += 100 * (divisor - 8) / divisor; }
				if (champadcmain[i] == 10) { champdict[enterchamp[i]] += 100 * (divisor - 9) / divisor; }
			}
			for (int i = 0; i < 10; i++)
			{
				if (champadc[i] == divisor - notMains + 1) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100) / divisor; }
				if (champadc[i] == divisor - notMains + 2) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 100) / divisor; }
				if (champadc[i] == divisor - notMains + 3) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 200) / divisor; }
				if (champadc[i] == divisor - notMains + 4) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 300) / divisor; }
				if (champadc[i] == divisor - notMains + 5) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 400) / divisor; }
				if (champadc[i] == divisor - notMains + 6) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 500) / divisor; }
				if (champadc[i] == divisor - notMains + 7) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 600) / divisor; }
				if (champadc[i] == divisor - notMains + 8) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 700) / divisor; }
				if (champadc[i] == divisor - notMains + 9) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 800) / divisor; }
				if (champadc[i] == divisor - notMains + 10)
				{
					champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 900) / divisor;
				}
			}
			int[] champsupmain = new int[10];
			int[] champsup = new int[10];
			contador = 0;
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 3] == 2)
				{
					champsupmain[i] = contador + 1;
					contador += 1;
				}
			}
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 3] == 1)
				{
					champsup[i] = contador + 1;
					contador += 1;
				}
			}

			divisor = 0;
			notMains = 0;
			if (champsup[0] > 0 || champsupmain[0] > 0) { divisor += 1; }
			if (champsup[1] > 0 || champsupmain[1] > 0) { divisor += 1; }
			if (champsup[2] > 0 || champsupmain[2] > 0) { divisor += 1; }
			if (champsup[3] > 0 || champsupmain[3] > 0) { divisor += 1; }
			if (champsup[4] > 0 || champsupmain[4] > 0) { divisor += 1; }
			if (champsup[5] > 0 || champsupmain[5] > 0) { divisor += 1; }
			if (champsup[6] > 0 || champsupmain[6] > 0) { divisor += 1; }
			if (champsup[7] > 0 || champsupmain[7] > 0) { divisor += 1; }
			if (champsup[8] > 0 || champsupmain[8] > 0) { divisor += 1; }
			if (champsup[9] > 0 || champsupmain[9] > 0) { divisor += 1; }

			if (champsup[0] > 0) { notMains += 1; }
			if (champsup[1] > 0) { notMains += 1; }
			if (champsup[2] > 0) { notMains += 1; }
			if (champsup[3] > 0) { notMains += 1; }
			if (champsup[4] > 0) { notMains += 1; }
			if (champsup[5] > 0) { notMains += 1; }
			if (champsup[6] > 0) { notMains += 1; }
			if (champsup[7] > 0) { notMains += 1; }
			if (champsup[8] > 0) { notMains += 1; }
			if (champsup[9] > 0) { notMains += 1; }

			
			
			for (int i = 0; i < 10; i++)
			{
				if (champsupmain[i] == 1) { champdict[enterchamp[i]] += 100; }
				if (champsupmain[i] == 2) { champdict[enterchamp[i]] += 100 * (divisor - 1) / divisor; }
				if (champsupmain[i] == 3) { champdict[enterchamp[i]] += 100 * (divisor - 2) / divisor; }
				if (champsupmain[i] == 4) { champdict[enterchamp[i]] += 100 * (divisor - 3) / divisor; }
				if (champsupmain[i] == 5) { champdict[enterchamp[i]] += 100 * (divisor - 4) / divisor; }
				if (champsupmain[i] == 6) { champdict[enterchamp[i]] += 100 * (divisor - 5) / divisor; }
				if (champsupmain[i] == 7) { champdict[enterchamp[i]] += 100 * (divisor - 6) / divisor; }
				if (champsupmain[i] == 8) { champdict[enterchamp[i]] += 100 * (divisor - 7) / divisor; }
				if (champsupmain[i] == 9) { champdict[enterchamp[i]] += 100 * (divisor - 8) / divisor; }
				if (champsupmain[i] == 10) { champdict[enterchamp[i]] += 100 * (divisor - 9) / divisor; }
			}
			for (int i = 0; i < 10; i++)
			{
				if (champsup[i] == divisor - notMains + 1) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100) / divisor; }
				if (champsup[i] == divisor - notMains + 2) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 100) / divisor; }
				if (champsup[i] == divisor - notMains + 3) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 200) / divisor; }
				if (champsup[i] == divisor - notMains + 4) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 300) / divisor; }
				if (champsup[i] == divisor - notMains + 5) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 400) / divisor; }
				if (champsup[i] == divisor - notMains + 6) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 500) / divisor; }
				if (champsup[i] == divisor - notMains + 7) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 600) / divisor; }
				if (champsup[i] == divisor - notMains + 8) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 700) / divisor; }
				if (champsup[i] == divisor - notMains + 9) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 800) / divisor; }
				if (champsup[i] == divisor - notMains + 10)
				{
					champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 900) / divisor;
				}
			}

			int[] champjgmain = new int[10];
			int[] champjg = new int[10];
			contador = 0;
			for(int i = 0; i < 10; i++)
			{
				if(championsRole[champScore[i], 4] == 2)
				{
					champjgmain[i] = contador + 1;
					contador += 1;
				}
			}
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 4] == 1)
				{
					champjg[i] = contador + 1;
					contador += 1;
				}
			}

			divisor = 0;
			notMains = 0;
			if (champjg[0] > 0 || champjgmain[0] > 0) { divisor += 1; }
			if (champjg[1] > 0 || champjgmain[1] > 0) { divisor += 1; }
			if (champjg[2] > 0 || champjgmain[2] > 0) { divisor += 1; }
			if (champjg[3] > 0 || champjgmain[3] > 0) { divisor += 1; }
			if (champjg[4] > 0 || champjgmain[4] > 0) { divisor += 1; }
			if (champjg[5] > 0 || champjgmain[5] > 0) { divisor += 1; }
			if (champjg[6] > 0 || champjgmain[6] > 0) { divisor += 1; }
			if (champjg[7] > 0 || champjgmain[7] > 0) { divisor += 1; }
			if (champjg[8] > 0 || champjgmain[8] > 0) { divisor += 1; }
			if (champjg[9] > 0 || champjgmain[9] > 0) { divisor += 1; }
	
			if (champjg[0] > 0) { notMains += 1; }
			if (champjg[1] > 0) { notMains += 1; }
			if (champjg[2] > 0) { notMains += 1; }
			if (champjg[3] > 0) { notMains += 1; }
			if (champjg[4] > 0) { notMains += 1; }
			if (champjg[5] > 0) { notMains += 1; }
			if (champjg[6] > 0) { notMains += 1; }
			if (champjg[7] > 0) { notMains += 1; }
			if (champjg[8] > 0) { notMains += 1; }
			if (champjg[9] > 0) { notMains += 1; }
			
			
			
			for(int i = 0; i < 10; i++)
			{
				if (champjgmain[i] == 1) { champdict[enterchamp[i]] += 100; }
				if (champjgmain[i] == 2) { champdict[enterchamp[i]] += 100*(divisor-1)/divisor; }
				if (champjgmain[i] == 3) { champdict[enterchamp[i]] += 100*(divisor-2)/divisor; }
				if (champjgmain[i] == 4) { champdict[enterchamp[i]] += 100*(divisor-3)/divisor; }
				if (champjgmain[i] == 5) { champdict[enterchamp[i]] += 100*(divisor-4)/divisor; }
				if (champjgmain[i] == 6) { champdict[enterchamp[i]] += 100*(divisor-5)/divisor; }
				if (champjgmain[i] == 7) { champdict[enterchamp[i]] += 100*(divisor-6)/divisor; }
				if (champjgmain[i] == 8) { champdict[enterchamp[i]] += 100*(divisor-7)/divisor; }
				if (champjgmain[i] == 9) { champdict[enterchamp[i]] += 100*(divisor-8)/divisor; }
				if (champjgmain[i] == 10) { champdict[enterchamp[i]] += 100*(divisor-9)/divisor; }
			}
			for(int i = 0; i<10; i++)
			{
				if (champjg[i] == divisor - notMains + 1) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100) / divisor; }
				if (champjg[i] == divisor - notMains + 2) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 100) / divisor; }
				if (champjg[i] == divisor - notMains + 3) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 200) / divisor; }
				if (champjg[i] == divisor - notMains + 4) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 300) / divisor; }
				if (champjg[i] == divisor - notMains + 5) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 400) / divisor; }
				if (champjg[i] == divisor - notMains + 6) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 500) / divisor; }
				if (champjg[i] == divisor - notMains + 7) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 600) / divisor; }
				if (champjg[i] == divisor - notMains + 8) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 700) / divisor; }
				if (champjg[i] == divisor - notMains + 9) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 800) / divisor; }
				if (champjg[i] == divisor - notMains + 10)
				{
					champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 900) / divisor;
				}
			}
	
			var sortedDict = from entry in champdict orderby entry.Value descending select entry;
			foreach (var x in sortedDict)
			{
				Console.WriteLine(x);
			}


			Console.WriteLine("PRATA:");
			championsRole[champdict["karthus"], 0] = 1;
			championsRole[champdict["karthus"], 1] = 1;
			championsRole[champdict["karthus"], 2] = 1;
			championsRole[champdict["karthus"], 3] = 1;
			championsRole[champdict["karthus"], 4] = 2;
			championsRole[champdict["skarner"], 0] = 1;
			championsRole[champdict["skarner"], 4] = 2;
			championsRole[champdict["hecarim"], 0] = 1;
			championsRole[champdict["hecarim"], 4] = 2;
			championsRole[champdict["swain"], 0] = 1;
			championsRole[champdict["swain"], 1] = 2;
			championsRole[champdict["swain"], 2] = 1;
			championsRole[champdict["swain"], 3] = 1;
			championsRole[champdict["urgot"], 0] = 2;
			championsRole[champdict["urgot"], 1] = 1;
			championsRole[champdict["rammus"], 0] = 1;
			championsRole[champdict["rammus"], 4] = 2;
			championsRole[champdict["nunu"], 1] = 1;
			championsRole[champdict["nunu"], 4] = 2;
			championsRole[champdict["zilean"], 1] = 1;
			championsRole[champdict["zilean"], 3] = 2;
			championsRole[champdict["udyr"], 4] = 2;
			championsRole[champdict["singed"], 0] = 2;
			championsRole[champdict["annie"], 0] = 1;
			championsRole[champdict["annie"], 1] = 2;
			championsRole[champdict["annie"], 3] = 1;
			championsRole[champdict["kog'maw"], 0] = 1;
			championsRole[champdict["kog'maw"], 1] = 1;
			championsRole[champdict["kog'maw"], 3] = 2;
			championsRole[champdict["heimerdinger"], 0] = 1;
			championsRole[champdict["heimerdinger"], 1] = 2;
			championsRole[champdict["heimerdinger"], 3] = 1;
			championsRole[champdict["aurelionsol"], 0] = 1;
			championsRole[champdict["aurelionsol"], 1] = 2;
			championsRole[champdict["ivern"], 0] = 1;
			championsRole[champdict["ivern"], 3] = 1;
			championsRole[champdict["ivern"], 4] = 2;
			championsRole[champdict["quinn"], 0] = 1;
			championsRole[champdict["quinn"], 1] = 2;
			championsRole[champdict["shyvanna"], 0] = 1;
			championsRole[champdict["shyvanna"], 4] = 2;
			championsRole[champdict["tahmkench"], 0] = 2;
			championsRole[champdict["tahmkench"], 3] = 1;
			championsRole[champdict["yorick"], 0] = 2;
			championsRole[champdict["fiddlesticks"], 0] = 1;
			championsRole[champdict["fiddlesticks"], 1] = 1;
			championsRole[champdict["fiddlesticks"], 3] = 1;
			championsRole[champdict["fiddlesticks"], 4] = 2;
			championsRole[champdict["dr.mundo"], 0] = 2;
			championsRole[champdict["dr.mundo"], 4] = 1;
			championsRole[champdict["evelynn"], 4] = 2;
			championsRole[champdict["rengar"], 0] = 2;
			championsRole[champdict["rengar"], 4] = 1;
			championsRole[champdict["cho'gath"], 0] = 1;
			championsRole[champdict["cho'gath"], 1] = 2;
			championsRole[champdict["cho'gath"], 3] = 1;
			championsRole[champdict["cho'gath"], 4] = 1;
			championsRole[champdict["nasus"], 0] = 1;
			championsRole[champdict["nasus"], 1] = 1;
			championsRole[champdict["rek'sai"], 0] = 1;
			championsRole[champdict["rek'sai"], 4] = 2;
			championsRole[champdict["vi"], 4] = 2;
			championsRole[champdict["kled"], 0] = 1;
			championsRole[champdict["kled"], 1] = 1;
			championsRole[champdict["taliyah"], 1] = 1;
			championsRole[champdict["taliyah"], 3] = 1;
			championsRole[champdict["taliyah"], 4] = 1;
			championsRole[champdict["amumu"], 3] = 1;
			championsRole[champdict["amumu"], 4] = 2;
			championsRole[champdict["kayle"], 0] = 2;
			championsRole[champdict["kayle"], 1] = 1;
			championsRole[champdict["garen"], 0] = 2;
			championsRole[champdict["garen"], 1] = 1;
			championsRole[champdict["tryndamere"], 0] = 2;
			championsRole[champdict["tryndamere"], 1] = 1;
			championsRole[champdict["tryndamere"], 4] = 1;
			championsRole[champdict["azir"], 0] = 1;
			championsRole[champdict["azir"], 1] = 2;
			championsRole[champdict["ziggs"], 0] = 1;
			championsRole[champdict["ziggs"], 1] = 2;
			championsRole[champdict["ziggs"], 3] = 1;
			championsRole[champdict["wukong"], 0] = 1;
			championsRole[champdict["wukong"], 2] = 1;
			championsRole[champdict["wukong"], 4] = 2;
			championsRole[champdict["lissandra"], 0] = 1;
			championsRole[champdict["lissandra"], 2] = 2;
			championsRole[champdict["anivia"], 2] = 2;
			championsRole[champdict["olaf"], 0] = 1;
			championsRole[champdict["olaf"], 4] = 2;
			championsRole[champdict["braum"], 3] = 2;
			championsRole[champdict["galio"], 2] = 2;
			championsRole[champdict["galio"], 3] = 1;
			championsRole[champdict["poppy"], 0] = 2;
			championsRole[champdict["poppy"], 3] = 1;
			championsRole[champdict["poppy"], 4] = 1;
			championsRole[champdict["xinzhao"], 0] = 1;
			championsRole[champdict["xinzhao"], 2] = 1;
			championsRole[champdict["zac"], 0] = 1;
			championsRole[champdict["zac"], 3] = 1;
			championsRole[champdict["zac"], 4] = 2;
			championsRole[champdict["rumble"], 0] = 1;
			championsRole[champdict["rumble"], 2] = 2;
			championsRole[champdict["sion"], 0] = 2;
			championsRole[champdict["sion"], 2] = 1;
			championsRole[champdict["sion"], 3] = 1;
			championsRole[champdict["sion"], 4] = 1;
			championsRole[champdict["illaoi"], 0] = 2;
			championsRole[champdict["illaoi"], 2] = 1;
			championsRole[champdict["khazix"], 4] = 2;
			championsRole[champdict["masteryi"], 0] = 1;
			championsRole[champdict["masteryi"], 4] = 2;
			enterchamp = Console.ReadLine().Split(" ");

			 champScore = new int[10];
			for (int i = 0; i < 10; i++)
			{
				champScore[i] = champdict[enterchamp[i]];
			}

			 champtopmain = new int[10];
			 champtop = new int[10];
			contador = 0;
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 0] == 2)
				{
					champtopmain[i] = contador + 1;
					contador += 1;
				}
			}
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 0] == 1)
				{
					champtop[i] = contador + 1;
					Console.WriteLine(champScore[i]);
					Console.WriteLine(champtop[i]);
					contador += 1;
				}
			}

			divisor = 0;
			notMains = 0;
			if (champtop[0] > 0 || champtopmain[0] > 0) { divisor += 1; }
			if (champtop[1] > 0 || champtopmain[1] > 0) { divisor += 1; }
			if (champtop[2] > 0 || champtopmain[2] > 0) { divisor += 1; }
			if (champtop[3] > 0 || champtopmain[3] > 0) { divisor += 1; }
			if (champtop[4] > 0 || champtopmain[4] > 0) { divisor += 1; }
			if (champtop[5] > 0 || champtopmain[5] > 0) { divisor += 1; }
			if (champtop[6] > 0 || champtopmain[6] > 0) { divisor += 1; }
			if (champtop[7] > 0 || champtopmain[7] > 0) { divisor += 1; }
			if (champtop[8] > 0 || champtopmain[8] > 0) { divisor += 1; }
			if (champtop[9] > 0 || champtopmain[9] > 0) { divisor += 1; }

			if (champtop[0] > 0) { notMains += 1; }
			if (champtop[1] > 0) { notMains += 1; }
			if (champtop[2] > 0) { notMains += 1; }
			if (champtop[3] > 0) { notMains += 1; }
			if (champtop[4] > 0) { notMains += 1; }
			if (champtop[5] > 0) { notMains += 1; }
			if (champtop[6] > 0) { notMains += 1; }
			if (champtop[7] > 0) { notMains += 1; }
			if (champtop[8] > 0) { notMains += 1; }
			if (champtop[9] > 0) { notMains += 1; }

			for (int i = 0; i < 10; i++)
			{
				if (champtopmain[i] == 1) { champdict[enterchamp[i]] += 100; }
				if (champtopmain[i] == 2) { champdict[enterchamp[i]] += 100 * (divisor - 1) / divisor; }
				if (champtopmain[i] == 3) { champdict[enterchamp[i]] += 100 * (divisor - 2) / divisor; }
				if (champtopmain[i] == 4) { champdict[enterchamp[i]] += 100 * (divisor - 3) / divisor; }
				if (champtopmain[i] == 5) { champdict[enterchamp[i]] += 100 * (divisor - 4) / divisor; }
				if (champtopmain[i] == 6) { champdict[enterchamp[i]] += 100 * (divisor - 5) / divisor; }
				if (champtopmain[i] == 7) { champdict[enterchamp[i]] += 100 * (divisor - 6) / divisor; }
				if (champtopmain[i] == 8) { champdict[enterchamp[i]] += 100 * (divisor - 7) / divisor; }
				if (champtopmain[i] == 9) { champdict[enterchamp[i]] += 100 * (divisor - 8) / divisor; }
				if (champtopmain[i] == 10) { champdict[enterchamp[i]] += 100 * (divisor - 9) / divisor; }
			}
			for (int i = 0; i < 10; i++)
			{
				if (champtop[i] == divisor - notMains + 1) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100) / divisor; }
				if (champtop[i] == divisor - notMains + 2) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 100) / divisor; }
				if (champtop[i] == divisor - notMains + 3) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 200) / divisor; }
				if (champtop[i] == divisor - notMains + 4) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 300) / divisor; }
				if (champtop[i] == divisor - notMains + 5) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 400) / divisor; }
				if (champtop[i] == divisor - notMains + 6) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 500) / divisor; }
				if (champtop[i] == divisor - notMains + 7) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 600) / divisor; }
				if (champtop[i] == divisor - notMains + 8) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 700) / divisor; }
				if (champtop[i] == divisor - notMains + 9) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 800) / divisor; }
				if (champtop[i] == divisor - notMains + 10) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 900) / divisor; }
			}

			 champmidmain = new int[10];
			 champmid = new int[10];
			contador = 0;
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 1] == 2)
				{
					champmidmain[i] = contador + 1;
					contador += 1;
				}
			}
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 1] == 1)
				{
					champmid[i] = contador + 1;
					contador += 1;
				}
			}

			divisor = 0;
			notMains = 0;
			if (champmid[0] > 0 || champmidmain[0] > 0) { divisor += 1; }
			if (champmid[1] > 0 || champmidmain[1] > 0) { divisor += 1; }
			if (champmid[2] > 0 || champmidmain[2] > 0) { divisor += 1; }
			if (champmid[3] > 0 || champmidmain[3] > 0) { divisor += 1; }
			if (champmid[4] > 0 || champmidmain[4] > 0) { divisor += 1; }
			if (champmid[5] > 0 || champmidmain[5] > 0) { divisor += 1; }
			if (champmid[6] > 0 || champmidmain[6] > 0) { divisor += 1; }
			if (champmid[7] > 0 || champmidmain[7] > 0) { divisor += 1; }
			if (champmid[8] > 0 || champmidmain[8] > 0) { divisor += 1; }
			if (champmid[9] > 0 || champmidmain[9] > 0) { divisor += 1; }

			if (champmid[0] > 0) { notMains += 1; }
			if (champmid[1] > 0) { notMains += 1; }
			if (champmid[2] > 0) { notMains += 1; }
			if (champmid[3] > 0) { notMains += 1; }
			if (champmid[4] > 0) { notMains += 1; }
			if (champmid[5] > 0) { notMains += 1; }
			if (champmid[6] > 0) { notMains += 1; }
			if (champmid[7] > 0) { notMains += 1; }
			if (champmid[8] > 0) { notMains += 1; }
			if (champmid[9] > 0) { notMains += 1; }

			for (int i = 0; i < 10; i++)
			{
				if (champmidmain[i] == 1) { champdict[enterchamp[i]] += 100; }
				if (champmidmain[i] == 2) { champdict[enterchamp[i]] += 100 * (divisor - 1) / divisor; }
				if (champmidmain[i] == 3) { champdict[enterchamp[i]] += 100 * (divisor - 2) / divisor; }
				if (champmidmain[i] == 4) { champdict[enterchamp[i]] += 100 * (divisor - 3) / divisor; }
				if (champmidmain[i] == 5) { champdict[enterchamp[i]] += 100 * (divisor - 4) / divisor; }
				if (champmidmain[i] == 6) { champdict[enterchamp[i]] += 100 * (divisor - 5) / divisor; }
				if (champmidmain[i] == 7) { champdict[enterchamp[i]] += 100 * (divisor - 6) / divisor; }
				if (champmidmain[i] == 8) { champdict[enterchamp[i]] += 100 * (divisor - 7) / divisor; }
				if (champmidmain[i] == 9) { champdict[enterchamp[i]] += 100 * (divisor - 8) / divisor; }
				if (champmidmain[i] == 10) { champdict[enterchamp[i]] += 100 * (divisor - 9) / divisor; }
			}
			for (int i = 0; i < 10; i++)
			{
				if (champmid[i] == divisor - notMains + 1) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100) / divisor; }
				if (champmid[i] == divisor - notMains + 2) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 100) / divisor; }
				if (champmid[i] == divisor - notMains + 3) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 200) / divisor; }
				if (champmid[i] == divisor - notMains + 4) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 300) / divisor; }
				if (champmid[i] == divisor - notMains + 5) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 400) / divisor; }
				if (champmid[i] == divisor - notMains + 6) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 500) / divisor; }
				if (champmid[i] == divisor - notMains + 7) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 600) / divisor; }
				if (champmid[i] == divisor - notMains + 8) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 700) / divisor; }
				if (champmid[i] == divisor - notMains + 9) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 800) / divisor; }
				if (champmid[i] == divisor - notMains + 10) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 900) / divisor; }
			}


			 champadcmain = new int[10];
			 champadc = new int[10];
			contador = 0;
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 2] == 2)
				{
					champadcmain[i] = contador + 1;
					contador += 1;
				}
			}
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 2] == 1)
				{
					champadc[i] = contador + 1;
					contador += 1;
				}
			}

			divisor = 0;
			notMains = 0;
			if (champadc[0] > 0 || champadcmain[0] > 0) { divisor += 1; }
			if (champadc[1] > 0 || champadcmain[1] > 0) { divisor += 1; }
			if (champadc[2] > 0 || champadcmain[2] > 0) { divisor += 1; }
			if (champadc[3] > 0 || champadcmain[3] > 0) { divisor += 1; }
			if (champadc[4] > 0 || champadcmain[4] > 0) { divisor += 1; }
			if (champadc[5] > 0 || champadcmain[5] > 0) { divisor += 1; }
			if (champadc[6] > 0 || champadcmain[6] > 0) { divisor += 1; }
			if (champadc[7] > 0 || champadcmain[7] > 0) { divisor += 1; }
			if (champadc[8] > 0 || champadcmain[8] > 0) { divisor += 1; }
			if (champadc[9] > 0 || champadcmain[9] > 0) { divisor += 1; }

			if (champadc[0] > 0) { notMains += 1; }
			if (champadc[1] > 0) { notMains += 1; }
			if (champadc[2] > 0) { notMains += 1; }
			if (champadc[3] > 0) { notMains += 1; }
			if (champadc[4] > 0) { notMains += 1; }
			if (champadc[5] > 0) { notMains += 1; }
			if (champadc[6] > 0) { notMains += 1; }
			if (champadc[7] > 0) { notMains += 1; }
			if (champadc[8] > 0) { notMains += 1; }
			if (champadc[9] > 0) { notMains += 1; }



			for (int i = 0; i < 10; i++)
			{
				if (champadcmain[i] == 1) { champdict[enterchamp[i]] += 100; }
				if (champadcmain[i] == 2) { champdict[enterchamp[i]] += 100 * (divisor - 1) / divisor; }
				if (champadcmain[i] == 3) { champdict[enterchamp[i]] += 100 * (divisor - 2) / divisor; }
				if (champadcmain[i] == 4) { champdict[enterchamp[i]] += 100 * (divisor - 3) / divisor; }
				if (champadcmain[i] == 5) { champdict[enterchamp[i]] += 100 * (divisor - 4) / divisor; }
				if (champadcmain[i] == 6) { champdict[enterchamp[i]] += 100 * (divisor - 5) / divisor; }
				if (champadcmain[i] == 7) { champdict[enterchamp[i]] += 100 * (divisor - 6) / divisor; }
				if (champadcmain[i] == 8) { champdict[enterchamp[i]] += 100 * (divisor - 7) / divisor; }
				if (champadcmain[i] == 9) { champdict[enterchamp[i]] += 100 * (divisor - 8) / divisor; }
				if (champadcmain[i] == 10) { champdict[enterchamp[i]] += 100 * (divisor - 9) / divisor; }
			}
			for (int i = 0; i < 10; i++)
			{
				if (champadc[i] == divisor - notMains + 1) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100) / divisor; }
				if (champadc[i] == divisor - notMains + 2) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 100) / divisor; }
				if (champadc[i] == divisor - notMains + 3) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 200) / divisor; }
				if (champadc[i] == divisor - notMains + 4) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 300) / divisor; }
				if (champadc[i] == divisor - notMains + 5) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 400) / divisor; }
				if (champadc[i] == divisor - notMains + 6) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 500) / divisor; }
				if (champadc[i] == divisor - notMains + 7) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 600) / divisor; }
				if (champadc[i] == divisor - notMains + 8) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 700) / divisor; }
				if (champadc[i] == divisor - notMains + 9) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 800) / divisor; }
				if (champadc[i] == divisor - notMains + 10)
				{
					champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 900) / divisor;
				}
			}
			 champsupmain = new int[10];
			 champsup = new int[10];
			contador = 0;
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 3] == 2)
				{
					champsupmain[i] = contador + 1;
					contador += 1;
				}
			}
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 3] == 1)
				{
					champsup[i] = contador + 1;
					contador += 1;
				}
			}

			divisor = 0;
			notMains = 0;
			if (champsup[0] > 0 || champsupmain[0] > 0) { divisor += 1; }
			if (champsup[1] > 0 || champsupmain[1] > 0) { divisor += 1; }
			if (champsup[2] > 0 || champsupmain[2] > 0) { divisor += 1; }
			if (champsup[3] > 0 || champsupmain[3] > 0) { divisor += 1; }
			if (champsup[4] > 0 || champsupmain[4] > 0) { divisor += 1; }
			if (champsup[5] > 0 || champsupmain[5] > 0) { divisor += 1; }
			if (champsup[6] > 0 || champsupmain[6] > 0) { divisor += 1; }
			if (champsup[7] > 0 || champsupmain[7] > 0) { divisor += 1; }
			if (champsup[8] > 0 || champsupmain[8] > 0) { divisor += 1; }
			if (champsup[9] > 0 || champsupmain[9] > 0) { divisor += 1; }

			if (champsup[0] > 0) { notMains += 1; }
			if (champsup[1] > 0) { notMains += 1; }
			if (champsup[2] > 0) { notMains += 1; }
			if (champsup[3] > 0) { notMains += 1; }
			if (champsup[4] > 0) { notMains += 1; }
			if (champsup[5] > 0) { notMains += 1; }
			if (champsup[6] > 0) { notMains += 1; }
			if (champsup[7] > 0) { notMains += 1; }
			if (champsup[8] > 0) { notMains += 1; }
			if (champsup[9] > 0) { notMains += 1; }



			for (int i = 0; i < 10; i++)
			{
				if (champsupmain[i] == 1) { champdict[enterchamp[i]] += 100; }
				if (champsupmain[i] == 2) { champdict[enterchamp[i]] += 100 * (divisor - 1) / divisor; }
				if (champsupmain[i] == 3) { champdict[enterchamp[i]] += 100 * (divisor - 2) / divisor; }
				if (champsupmain[i] == 4) { champdict[enterchamp[i]] += 100 * (divisor - 3) / divisor; }
				if (champsupmain[i] == 5) { champdict[enterchamp[i]] += 100 * (divisor - 4) / divisor; }
				if (champsupmain[i] == 6) { champdict[enterchamp[i]] += 100 * (divisor - 5) / divisor; }
				if (champsupmain[i] == 7) { champdict[enterchamp[i]] += 100 * (divisor - 6) / divisor; }
				if (champsupmain[i] == 8) { champdict[enterchamp[i]] += 100 * (divisor - 7) / divisor; }
				if (champsupmain[i] == 9) { champdict[enterchamp[i]] += 100 * (divisor - 8) / divisor; }
				if (champsupmain[i] == 10) { champdict[enterchamp[i]] += 100 * (divisor - 9) / divisor; }
			}
			for (int i = 0; i < 10; i++)
			{
				if (champsup[i] == divisor - notMains + 1) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100) / divisor; }
				if (champsup[i] == divisor - notMains + 2) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 100) / divisor; }
				if (champsup[i] == divisor - notMains + 3) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 200) / divisor; }
				if (champsup[i] == divisor - notMains + 4) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 300) / divisor; }
				if (champsup[i] == divisor - notMains + 5) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 400) / divisor; }
				if (champsup[i] == divisor - notMains + 6) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 500) / divisor; }
				if (champsup[i] == divisor - notMains + 7) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 600) / divisor; }
				if (champsup[i] == divisor - notMains + 8) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 700) / divisor; }
				if (champsup[i] == divisor - notMains + 9) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 800) / divisor; }
				if (champsup[i] == divisor - notMains + 10)
				{
					champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 900) / divisor;
				}
			}

			 champjgmain = new int[10];
			 champjg = new int[10];
			contador = 0;
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 4] == 2)
				{
					champjgmain[i] = contador + 1;
					contador += 1;
				}
			}
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 4] == 1)
				{
					champjg[i] = contador + 1;
					contador += 1;
				}
			}

			divisor = 0;
			notMains = 0;
			if (champjg[0] > 0 || champjgmain[0] > 0) { divisor += 1; }
			if (champjg[1] > 0 || champjgmain[1] > 0) { divisor += 1; }
			if (champjg[2] > 0 || champjgmain[2] > 0) { divisor += 1; }
			if (champjg[3] > 0 || champjgmain[3] > 0) { divisor += 1; }
			if (champjg[4] > 0 || champjgmain[4] > 0) { divisor += 1; }
			if (champjg[5] > 0 || champjgmain[5] > 0) { divisor += 1; }
			if (champjg[6] > 0 || champjgmain[6] > 0) { divisor += 1; }
			if (champjg[7] > 0 || champjgmain[7] > 0) { divisor += 1; }
			if (champjg[8] > 0 || champjgmain[8] > 0) { divisor += 1; }
			if (champjg[9] > 0 || champjgmain[9] > 0) { divisor += 1; }

			if (champjg[0] > 0) { notMains += 1; }
			if (champjg[1] > 0) { notMains += 1; }
			if (champjg[2] > 0) { notMains += 1; }
			if (champjg[3] > 0) { notMains += 1; }
			if (champjg[4] > 0) { notMains += 1; }
			if (champjg[5] > 0) { notMains += 1; }
			if (champjg[6] > 0) { notMains += 1; }
			if (champjg[7] > 0) { notMains += 1; }
			if (champjg[8] > 0) { notMains += 1; }
			if (champjg[9] > 0) { notMains += 1; }



			for (int i = 0; i < 10; i++)
			{
				if (champjgmain[i] == 1) { champdict[enterchamp[i]] += 100; }
				if (champjgmain[i] == 2) { champdict[enterchamp[i]] += 100 * (divisor - 1) / divisor; }
				if (champjgmain[i] == 3) { champdict[enterchamp[i]] += 100 * (divisor - 2) / divisor; }
				if (champjgmain[i] == 4) { champdict[enterchamp[i]] += 100 * (divisor - 3) / divisor; }
				if (champjgmain[i] == 5) { champdict[enterchamp[i]] += 100 * (divisor - 4) / divisor; }
				if (champjgmain[i] == 6) { champdict[enterchamp[i]] += 100 * (divisor - 5) / divisor; }
				if (champjgmain[i] == 7) { champdict[enterchamp[i]] += 100 * (divisor - 6) / divisor; }
				if (champjgmain[i] == 8) { champdict[enterchamp[i]] += 100 * (divisor - 7) / divisor; }
				if (champjgmain[i] == 9) { champdict[enterchamp[i]] += 100 * (divisor - 8) / divisor; }
				if (champjgmain[i] == 10) { champdict[enterchamp[i]] += 100 * (divisor - 9) / divisor; }
			}
			for (int i = 0; i < 10; i++)
			{
				if (champjg[i] == divisor - notMains + 1) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100) / divisor; }
				if (champjg[i] == divisor - notMains + 2) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 100) / divisor; }
				if (champjg[i] == divisor - notMains + 3) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 200) / divisor; }
				if (champjg[i] == divisor - notMains + 4) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 300) / divisor; }
				if (champjg[i] == divisor - notMains + 5) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 400) / divisor; }
				if (champjg[i] == divisor - notMains + 6) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 500) / divisor; }
				if (champjg[i] == divisor - notMains + 7) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 600) / divisor; }
				if (champjg[i] == divisor - notMains + 8) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 700) / divisor; }
				if (champjg[i] == divisor - notMains + 9) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 800) / divisor; }
				if (champjg[i] == divisor - notMains + 10)
				{
					champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 900) / divisor;
				}
			}
			var sortedDict2 = from entry in champdict orderby entry.Value descending select entry;
			foreach (var x in sortedDict)
			{
				Console.WriteLine(x);
			}

			Console.WriteLine("OURO:");
			championsRole[champdict["karthus"], 0] = 1;
			championsRole[champdict["karthus"], 1] = 1;
			championsRole[champdict["karthus"], 2] = 1;
			championsRole[champdict["karthus"], 3] = 1;
			championsRole[champdict["karthus"], 4] = 2;
			championsRole[champdict["skarner"], 0] = 1;
			championsRole[champdict["skarner"], 4] = 2;
			championsRole[champdict["hecarim"], 0] = 1;
			championsRole[champdict["hecarim"], 4] = 2;
			championsRole[champdict["swain"], 0] = 1;
			championsRole[champdict["swain"], 1] = 2;
			championsRole[champdict["swain"], 2] = 1;
			championsRole[champdict["swain"], 3] = 1;
			championsRole[champdict["urgot"], 0] = 2;
			championsRole[champdict["urgot"], 1] = 1;
			championsRole[champdict["rammus"], 0] = 1;
			championsRole[champdict["rammus"], 4] = 2;
			championsRole[champdict["nunu"], 1] = 1;
			championsRole[champdict["nunu"], 4] = 2;
			championsRole[champdict["zilean"], 1] = 1;
			championsRole[champdict["zilean"], 3] = 2;
			championsRole[champdict["udyr"], 4] = 2;
			championsRole[champdict["singed"], 0] = 2;
			championsRole[champdict["annie"], 0] = 1;
			championsRole[champdict["annie"], 1] = 2;
			championsRole[champdict["annie"], 3] = 1;
			championsRole[champdict["kog'maw"], 0] = 1;
			championsRole[champdict["kog'maw"], 1] = 1;
			championsRole[champdict["kog'maw"], 3] = 2;
			championsRole[champdict["heimerdinger"], 0] = 1;
			championsRole[champdict["heimerdinger"], 1] = 2;
			championsRole[champdict["heimerdinger"], 3] = 1;
			championsRole[champdict["aurelionsol"], 0] = 1;
			championsRole[champdict["aurelionsol"], 1] = 2;
			championsRole[champdict["ivern"], 0] = 1;
			championsRole[champdict["ivern"], 3] = 1;
			championsRole[champdict["ivern"], 4] = 2;
			championsRole[champdict["quinn"], 0] = 1;
			championsRole[champdict["quinn"], 1] = 2;
			championsRole[champdict["shyvanna"], 0] = 1;
			championsRole[champdict["shyvanna"], 4] = 2;
			championsRole[champdict["tahmkench"], 0] = 2;
			championsRole[champdict["tahmkench"], 3] = 1;
			championsRole[champdict["yorick"], 0] = 2;
			championsRole[champdict["fiddlesticks"], 0] = 1;
			championsRole[champdict["fiddlesticks"], 1] = 1;
			championsRole[champdict["fiddlesticks"], 3] = 1;
			championsRole[champdict["fiddlesticks"], 4] = 2;
			championsRole[champdict["dr.mundo"], 0] = 2;
			championsRole[champdict["dr.mundo"], 4] = 1;
			championsRole[champdict["evelynn"], 4] = 2;
			championsRole[champdict["rengar"], 0] = 2;
			championsRole[champdict["rengar"], 4] = 1;
			championsRole[champdict["cho'gath"], 0] = 1;
			championsRole[champdict["cho'gath"], 1] = 2;
			championsRole[champdict["cho'gath"], 3] = 1;
			championsRole[champdict["cho'gath"], 4] = 1;
			championsRole[champdict["nasus"], 0] = 1;
			championsRole[champdict["nasus"], 1] = 1;
			championsRole[champdict["rek'sai"], 0] = 1;
			championsRole[champdict["rek'sai"], 4] = 2;
			championsRole[champdict["vi"], 4] = 2;
			championsRole[champdict["kled"], 0] = 1;
			championsRole[champdict["kled"], 1] = 1;
			championsRole[champdict["taliyah"], 1] = 1;
			championsRole[champdict["taliyah"], 3] = 1;
			championsRole[champdict["taliyah"], 4] = 1;
			championsRole[champdict["amumu"], 3] = 1;
			championsRole[champdict["amumu"], 4] = 2;
			championsRole[champdict["kayle"], 0] = 2;
			championsRole[champdict["kayle"], 1] = 1;
			championsRole[champdict["garen"], 0] = 2;
			championsRole[champdict["garen"], 1] = 1;
			championsRole[champdict["tryndamere"], 0] = 2;
			championsRole[champdict["tryndamere"], 1] = 1;
			championsRole[champdict["tryndamere"], 4] = 1;
			championsRole[champdict["azir"], 0] = 1;
			championsRole[champdict["azir"], 1] = 2;
			championsRole[champdict["ziggs"], 0] = 1;
			championsRole[champdict["ziggs"], 1] = 2;
			championsRole[champdict["ziggs"], 3] = 1;
			championsRole[champdict["wukong"], 0] = 1;
			championsRole[champdict["wukong"], 2] = 1;
			championsRole[champdict["wukong"], 4] = 2;
			championsRole[champdict["lissandra"], 0] = 1;
			championsRole[champdict["lissandra"], 2] = 2;
			championsRole[champdict["anivia"], 2] = 2;
			championsRole[champdict["olaf"], 0] = 1;
			championsRole[champdict["olaf"], 4] = 2;
			championsRole[champdict["braum"], 3] = 2;
			championsRole[champdict["galio"], 2] = 2;
			championsRole[champdict["galio"], 3] = 1;
			championsRole[champdict["poppy"], 0] = 2;
			championsRole[champdict["poppy"], 3] = 1;
			championsRole[champdict["poppy"], 4] = 1;
			championsRole[champdict["xinzhao"], 0] = 1;
			championsRole[champdict["xinzhao"], 2] = 1;
			championsRole[champdict["zac"], 0] = 1;
			championsRole[champdict["zac"], 3] = 1;
			championsRole[champdict["zac"], 4] = 2;
			championsRole[champdict["rumble"], 0] = 1;
			championsRole[champdict["rumble"], 2] = 2;
			championsRole[champdict["sion"], 0] = 2;
			championsRole[champdict["sion"], 2] = 1;
			championsRole[champdict["sion"], 3] = 1;
			championsRole[champdict["sion"], 4] = 1;
			championsRole[champdict["illaoi"], 0] = 2;
			championsRole[champdict["illaoi"], 2] = 1;
			championsRole[champdict["khazix"], 4] = 2;
			championsRole[champdict["masteryi"], 0] = 1;
			championsRole[champdict["masteryi"], 4] = 2;
			enterchamp = Console.ReadLine().Split(" ");

			 champScore = new int[10];
			for (int i = 0; i < 10; i++)
			{
				champScore[i] = champdict[enterchamp[i]];
			}

			 champtopmain = new int[10];
			 champtop = new int[10];
			contador = 0;
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 0] == 2)
				{
					champtopmain[i] = contador + 1;
					contador += 1;
				}
			}
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 0] == 1)
				{
					champtop[i] = contador + 1;
					Console.WriteLine(champScore[i]);
					Console.WriteLine(champtop[i]);
					contador += 1;
				}
			}

			divisor = 0;
			 notMains = 0;
			if (champtop[0] > 0 || champtopmain[0] > 0) { divisor += 1; }
			if (champtop[1] > 0 || champtopmain[1] > 0) { divisor += 1; }
			if (champtop[2] > 0 || champtopmain[2] > 0) { divisor += 1; }
			if (champtop[3] > 0 || champtopmain[3] > 0) { divisor += 1; }
			if (champtop[4] > 0 || champtopmain[4] > 0) { divisor += 1; }
			if (champtop[5] > 0 || champtopmain[5] > 0) { divisor += 1; }
			if (champtop[6] > 0 || champtopmain[6] > 0) { divisor += 1; }
			if (champtop[7] > 0 || champtopmain[7] > 0) { divisor += 1; }
			if (champtop[8] > 0 || champtopmain[8] > 0) { divisor += 1; }
			if (champtop[9] > 0 || champtopmain[9] > 0) { divisor += 1; }

			if (champtop[0] > 0) { notMains += 1; }
			if (champtop[1] > 0) { notMains += 1; }
			if (champtop[2] > 0) { notMains += 1; }
			if (champtop[3] > 0) { notMains += 1; }
			if (champtop[4] > 0) { notMains += 1; }
			if (champtop[5] > 0) { notMains += 1; }
			if (champtop[6] > 0) { notMains += 1; }
			if (champtop[7] > 0) { notMains += 1; }
			if (champtop[8] > 0) { notMains += 1; }
			if (champtop[9] > 0) { notMains += 1; }

			for (int i = 0; i < 10; i++)
			{
				if (champtopmain[i] == 1) { champdict[enterchamp[i]] += 100; }
				if (champtopmain[i] == 2) { champdict[enterchamp[i]] += 100 * (divisor - 1) / divisor; }
				if (champtopmain[i] == 3) { champdict[enterchamp[i]] += 100 * (divisor - 2) / divisor; }
				if (champtopmain[i] == 4) { champdict[enterchamp[i]] += 100 * (divisor - 3) / divisor; }
				if (champtopmain[i] == 5) { champdict[enterchamp[i]] += 100 * (divisor - 4) / divisor; }
				if (champtopmain[i] == 6) { champdict[enterchamp[i]] += 100 * (divisor - 5) / divisor; }
				if (champtopmain[i] == 7) { champdict[enterchamp[i]] += 100 * (divisor - 6) / divisor; }
				if (champtopmain[i] == 8) { champdict[enterchamp[i]] += 100 * (divisor - 7) / divisor; }
				if (champtopmain[i] == 9) { champdict[enterchamp[i]] += 100 * (divisor - 8) / divisor; }
				if (champtopmain[i] == 10) { champdict[enterchamp[i]] += 100 * (divisor - 9) / divisor; }
			}
			for (int i = 0; i < 10; i++)
			{
				if (champtop[i] == divisor - notMains + 1) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100) / divisor; }
				if (champtop[i] == divisor - notMains + 2) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 100) / divisor; }
				if (champtop[i] == divisor - notMains + 3) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 200) / divisor; }
				if (champtop[i] == divisor - notMains + 4) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 300) / divisor; }
				if (champtop[i] == divisor - notMains + 5) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 400) / divisor; }
				if (champtop[i] == divisor - notMains + 6) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 500) / divisor; }
				if (champtop[i] == divisor - notMains + 7) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 600) / divisor; }
				if (champtop[i] == divisor - notMains + 8) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 700) / divisor; }
				if (champtop[i] == divisor - notMains + 9) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 800) / divisor; }
				if (champtop[i] == divisor - notMains + 10) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 900) / divisor; }
			}

			 champmidmain = new int[10];
			 champmid = new int[10];
			contador = 0;
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 1] == 2)
				{
					champmidmain[i] = contador + 1;
					contador += 1;
				}
			}
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 1] == 1)
				{
					champmid[i] = contador + 1;
					contador += 1;
				}
			}

			divisor = 0;
			notMains = 0;
			if (champmid[0] > 0 || champmidmain[0] > 0) { divisor += 1; }
			if (champmid[1] > 0 || champmidmain[1] > 0) { divisor += 1; }
			if (champmid[2] > 0 || champmidmain[2] > 0) { divisor += 1; }
			if (champmid[3] > 0 || champmidmain[3] > 0) { divisor += 1; }
			if (champmid[4] > 0 || champmidmain[4] > 0) { divisor += 1; }
			if (champmid[5] > 0 || champmidmain[5] > 0) { divisor += 1; }
			if (champmid[6] > 0 || champmidmain[6] > 0) { divisor += 1; }
			if (champmid[7] > 0 || champmidmain[7] > 0) { divisor += 1; }
			if (champmid[8] > 0 || champmidmain[8] > 0) { divisor += 1; }
			if (champmid[9] > 0 || champmidmain[9] > 0) { divisor += 1; }

			if (champmid[0] > 0) { notMains += 1; }
			if (champmid[1] > 0) { notMains += 1; }
			if (champmid[2] > 0) { notMains += 1; }
			if (champmid[3] > 0) { notMains += 1; }
			if (champmid[4] > 0) { notMains += 1; }
			if (champmid[5] > 0) { notMains += 1; }
			if (champmid[6] > 0) { notMains += 1; }
			if (champmid[7] > 0) { notMains += 1; }
			if (champmid[8] > 0) { notMains += 1; }
			if (champmid[9] > 0) { notMains += 1; }

			for (int i = 0; i < 10; i++)
			{
				if (champmidmain[i] == 1) { champdict[enterchamp[i]] += 100; }
				if (champmidmain[i] == 2) { champdict[enterchamp[i]] += 100 * (divisor - 1) / divisor; }
				if (champmidmain[i] == 3) { champdict[enterchamp[i]] += 100 * (divisor - 2) / divisor; }
				if (champmidmain[i] == 4) { champdict[enterchamp[i]] += 100 * (divisor - 3) / divisor; }
				if (champmidmain[i] == 5) { champdict[enterchamp[i]] += 100 * (divisor - 4) / divisor; }
				if (champmidmain[i] == 6) { champdict[enterchamp[i]] += 100 * (divisor - 5) / divisor; }
				if (champmidmain[i] == 7) { champdict[enterchamp[i]] += 100 * (divisor - 6) / divisor; }
				if (champmidmain[i] == 8) { champdict[enterchamp[i]] += 100 * (divisor - 7) / divisor; }
				if (champmidmain[i] == 9) { champdict[enterchamp[i]] += 100 * (divisor - 8) / divisor; }
				if (champmidmain[i] == 10) { champdict[enterchamp[i]] += 100 * (divisor - 9) / divisor; }
			}
			for (int i = 0; i < 10; i++)
			{
				if (champmid[i] == divisor - notMains + 1) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100) / divisor; }
				if (champmid[i] == divisor - notMains + 2) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 100) / divisor; }
				if (champmid[i] == divisor - notMains + 3) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 200) / divisor; }
				if (champmid[i] == divisor - notMains + 4) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 300) / divisor; }
				if (champmid[i] == divisor - notMains + 5) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 400) / divisor; }
				if (champmid[i] == divisor - notMains + 6) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 500) / divisor; }
				if (champmid[i] == divisor - notMains + 7) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 600) / divisor; }
				if (champmid[i] == divisor - notMains + 8) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 700) / divisor; }
				if (champmid[i] == divisor - notMains + 9) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 800) / divisor; }
				if (champmid[i] == divisor - notMains + 10) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 900) / divisor; }
			}


			 champadcmain = new int[10];
			 champadc = new int[10];
			contador = 0;
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 2] == 2)
				{
					champadcmain[i] = contador + 1;
					contador += 1;
				}
			}
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 2] == 1)
				{
					champadc[i] = contador + 1;
					contador += 1;
				}
			}

			divisor = 0;
			notMains = 0;
			if (champadc[0] > 0 || champadcmain[0] > 0) { divisor += 1; }
			if (champadc[1] > 0 || champadcmain[1] > 0) { divisor += 1; }
			if (champadc[2] > 0 || champadcmain[2] > 0) { divisor += 1; }
			if (champadc[3] > 0 || champadcmain[3] > 0) { divisor += 1; }
			if (champadc[4] > 0 || champadcmain[4] > 0) { divisor += 1; }
			if (champadc[5] > 0 || champadcmain[5] > 0) { divisor += 1; }
			if (champadc[6] > 0 || champadcmain[6] > 0) { divisor += 1; }
			if (champadc[7] > 0 || champadcmain[7] > 0) { divisor += 1; }
			if (champadc[8] > 0 || champadcmain[8] > 0) { divisor += 1; }
			if (champadc[9] > 0 || champadcmain[9] > 0) { divisor += 1; }

			if (champadc[0] > 0) { notMains += 1; }
			if (champadc[1] > 0) { notMains += 1; }
			if (champadc[2] > 0) { notMains += 1; }
			if (champadc[3] > 0) { notMains += 1; }
			if (champadc[4] > 0) { notMains += 1; }
			if (champadc[5] > 0) { notMains += 1; }
			if (champadc[6] > 0) { notMains += 1; }
			if (champadc[7] > 0) { notMains += 1; }
			if (champadc[8] > 0) { notMains += 1; }
			if (champadc[9] > 0) { notMains += 1; }



			for (int i = 0; i < 10; i++)
			{
				if (champadcmain[i] == 1) { champdict[enterchamp[i]] += 100; }
				if (champadcmain[i] == 2) { champdict[enterchamp[i]] += 100 * (divisor - 1) / divisor; }
				if (champadcmain[i] == 3) { champdict[enterchamp[i]] += 100 * (divisor - 2) / divisor; }
				if (champadcmain[i] == 4) { champdict[enterchamp[i]] += 100 * (divisor - 3) / divisor; }
				if (champadcmain[i] == 5) { champdict[enterchamp[i]] += 100 * (divisor - 4) / divisor; }
				if (champadcmain[i] == 6) { champdict[enterchamp[i]] += 100 * (divisor - 5) / divisor; }
				if (champadcmain[i] == 7) { champdict[enterchamp[i]] += 100 * (divisor - 6) / divisor; }
				if (champadcmain[i] == 8) { champdict[enterchamp[i]] += 100 * (divisor - 7) / divisor; }
				if (champadcmain[i] == 9) { champdict[enterchamp[i]] += 100 * (divisor - 8) / divisor; }
				if (champadcmain[i] == 10) { champdict[enterchamp[i]] += 100 * (divisor - 9) / divisor; }
			}
			for (int i = 0; i < 10; i++)
			{
				if (champadc[i] == divisor - notMains + 1) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100) / divisor; }
				if (champadc[i] == divisor - notMains + 2) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 100) / divisor; }
				if (champadc[i] == divisor - notMains + 3) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 200) / divisor; }
				if (champadc[i] == divisor - notMains + 4) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 300) / divisor; }
				if (champadc[i] == divisor - notMains + 5) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 400) / divisor; }
				if (champadc[i] == divisor - notMains + 6) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 500) / divisor; }
				if (champadc[i] == divisor - notMains + 7) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 600) / divisor; }
				if (champadc[i] == divisor - notMains + 8) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 700) / divisor; }
				if (champadc[i] == divisor - notMains + 9) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 800) / divisor; }
				if (champadc[i] == divisor - notMains + 10)
				{
					champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 900) / divisor;
				}
			}
			 champsupmain = new int[10];
			 champsup = new int[10];
			contador = 0;
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 3] == 2)
				{
					champsupmain[i] = contador + 1;
					contador += 1;
				}
			}
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 3] == 1)
				{
					champsup[i] = contador + 1;
					contador += 1;
				}
			}

			divisor = 0;
			notMains = 0;
			if (champsup[0] > 0 || champsupmain[0] > 0) { divisor += 1; }
			if (champsup[1] > 0 || champsupmain[1] > 0) { divisor += 1; }
			if (champsup[2] > 0 || champsupmain[2] > 0) { divisor += 1; }
			if (champsup[3] > 0 || champsupmain[3] > 0) { divisor += 1; }
			if (champsup[4] > 0 || champsupmain[4] > 0) { divisor += 1; }
			if (champsup[5] > 0 || champsupmain[5] > 0) { divisor += 1; }
			if (champsup[6] > 0 || champsupmain[6] > 0) { divisor += 1; }
			if (champsup[7] > 0 || champsupmain[7] > 0) { divisor += 1; }
			if (champsup[8] > 0 || champsupmain[8] > 0) { divisor += 1; }
			if (champsup[9] > 0 || champsupmain[9] > 0) { divisor += 1; }

			if (champsup[0] > 0) { notMains += 1; }
			if (champsup[1] > 0) { notMains += 1; }
			if (champsup[2] > 0) { notMains += 1; }
			if (champsup[3] > 0) { notMains += 1; }
			if (champsup[4] > 0) { notMains += 1; }
			if (champsup[5] > 0) { notMains += 1; }
			if (champsup[6] > 0) { notMains += 1; }
			if (champsup[7] > 0) { notMains += 1; }
			if (champsup[8] > 0) { notMains += 1; }
			if (champsup[9] > 0) { notMains += 1; }



			for (int i = 0; i < 10; i++)
			{
				if (champsupmain[i] == 1) { champdict[enterchamp[i]] += 100; }
				if (champsupmain[i] == 2) { champdict[enterchamp[i]] += 100 * (divisor - 1) / divisor; }
				if (champsupmain[i] == 3) { champdict[enterchamp[i]] += 100 * (divisor - 2) / divisor; }
				if (champsupmain[i] == 4) { champdict[enterchamp[i]] += 100 * (divisor - 3) / divisor; }
				if (champsupmain[i] == 5) { champdict[enterchamp[i]] += 100 * (divisor - 4) / divisor; }
				if (champsupmain[i] == 6) { champdict[enterchamp[i]] += 100 * (divisor - 5) / divisor; }
				if (champsupmain[i] == 7) { champdict[enterchamp[i]] += 100 * (divisor - 6) / divisor; }
				if (champsupmain[i] == 8) { champdict[enterchamp[i]] += 100 * (divisor - 7) / divisor; }
				if (champsupmain[i] == 9) { champdict[enterchamp[i]] += 100 * (divisor - 8) / divisor; }
				if (champsupmain[i] == 10) { champdict[enterchamp[i]] += 100 * (divisor - 9) / divisor; }
			}
			for (int i = 0; i < 10; i++)
			{
				if (champsup[i] == divisor - notMains + 1) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100) / divisor; }
				if (champsup[i] == divisor - notMains + 2) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 100) / divisor; }
				if (champsup[i] == divisor - notMains + 3) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 200) / divisor; }
				if (champsup[i] == divisor - notMains + 4) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 300) / divisor; }
				if (champsup[i] == divisor - notMains + 5) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 400) / divisor; }
				if (champsup[i] == divisor - notMains + 6) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 500) / divisor; }
				if (champsup[i] == divisor - notMains + 7) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 600) / divisor; }
				if (champsup[i] == divisor - notMains + 8) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 700) / divisor; }
				if (champsup[i] == divisor - notMains + 9) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 800) / divisor; }
				if (champsup[i] == divisor - notMains + 10)
				{
					champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 900) / divisor;
				}
			}

			 champjgmain = new int[10];
			 champjg = new int[10];
			contador = 0;
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 4] == 2)
				{
					champjgmain[i] = contador + 1;
					contador += 1;
				}
			}
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 4] == 1)
				{
					champjg[i] = contador + 1;
					contador += 1;
				}
			}

			divisor = 0;
			notMains = 0;
			if (champjg[0] > 0 || champjgmain[0] > 0) { divisor += 1; }
			if (champjg[1] > 0 || champjgmain[1] > 0) { divisor += 1; }
			if (champjg[2] > 0 || champjgmain[2] > 0) { divisor += 1; }
			if (champjg[3] > 0 || champjgmain[3] > 0) { divisor += 1; }
			if (champjg[4] > 0 || champjgmain[4] > 0) { divisor += 1; }
			if (champjg[5] > 0 || champjgmain[5] > 0) { divisor += 1; }
			if (champjg[6] > 0 || champjgmain[6] > 0) { divisor += 1; }
			if (champjg[7] > 0 || champjgmain[7] > 0) { divisor += 1; }
			if (champjg[8] > 0 || champjgmain[8] > 0) { divisor += 1; }
			if (champjg[9] > 0 || champjgmain[9] > 0) { divisor += 1; }

			if (champjg[0] > 0) { notMains += 1; }
			if (champjg[1] > 0) { notMains += 1; }
			if (champjg[2] > 0) { notMains += 1; }
			if (champjg[3] > 0) { notMains += 1; }
			if (champjg[4] > 0) { notMains += 1; }
			if (champjg[5] > 0) { notMains += 1; }
			if (champjg[6] > 0) { notMains += 1; }
			if (champjg[7] > 0) { notMains += 1; }
			if (champjg[8] > 0) { notMains += 1; }
			if (champjg[9] > 0) { notMains += 1; }



			for (int i = 0; i < 10; i++)
			{
				if (champjgmain[i] == 1) { champdict[enterchamp[i]] += 100; }
				if (champjgmain[i] == 2) { champdict[enterchamp[i]] += 100 * (divisor - 1) / divisor; }
				if (champjgmain[i] == 3) { champdict[enterchamp[i]] += 100 * (divisor - 2) / divisor; }
				if (champjgmain[i] == 4) { champdict[enterchamp[i]] += 100 * (divisor - 3) / divisor; }
				if (champjgmain[i] == 5) { champdict[enterchamp[i]] += 100 * (divisor - 4) / divisor; }
				if (champjgmain[i] == 6) { champdict[enterchamp[i]] += 100 * (divisor - 5) / divisor; }
				if (champjgmain[i] == 7) { champdict[enterchamp[i]] += 100 * (divisor - 6) / divisor; }
				if (champjgmain[i] == 8) { champdict[enterchamp[i]] += 100 * (divisor - 7) / divisor; }
				if (champjgmain[i] == 9) { champdict[enterchamp[i]] += 100 * (divisor - 8) / divisor; }
				if (champjgmain[i] == 10) { champdict[enterchamp[i]] += 100 * (divisor - 9) / divisor; }
			}
			for (int i = 0; i < 10; i++)
			{
				if (champjg[i] == divisor - notMains + 1) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100) / divisor; }
				if (champjg[i] == divisor - notMains + 2) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 100) / divisor; }
				if (champjg[i] == divisor - notMains + 3) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 200) / divisor; }
				if (champjg[i] == divisor - notMains + 4) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 300) / divisor; }
				if (champjg[i] == divisor - notMains + 5) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 400) / divisor; }
				if (champjg[i] == divisor - notMains + 6) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 500) / divisor; }
				if (champjg[i] == divisor - notMains + 7) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 600) / divisor; }
				if (champjg[i] == divisor - notMains + 8) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 700) / divisor; }
				if (champjg[i] == divisor - notMains + 9) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 800) / divisor; }
				if (champjg[i] == divisor - notMains + 10)
				{
					champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 900) / divisor;
				}
			}
			foreach (var x in sortedDict)
			{
				Console.WriteLine(x);
			}

			Console.WriteLine("PLATINA:");
			championsRole[champdict["karthus"], 0] = 1;
			championsRole[champdict["karthus"], 1] = 1;
			championsRole[champdict["karthus"], 2] = 1;
			championsRole[champdict["karthus"], 3] = 1;
			championsRole[champdict["karthus"], 4] = 2;
			championsRole[champdict["skarner"], 0] = 1;
			championsRole[champdict["skarner"], 4] = 2;
			championsRole[champdict["hecarim"], 0] = 1;
			championsRole[champdict["hecarim"], 4] = 2;
			championsRole[champdict["swain"], 0] = 1;
			championsRole[champdict["swain"], 1] = 2;
			championsRole[champdict["swain"], 2] = 1;
			championsRole[champdict["swain"], 3] = 1;
			championsRole[champdict["urgot"], 0] = 2;
			championsRole[champdict["urgot"], 1] = 1;
			championsRole[champdict["rammus"], 0] = 1;
			championsRole[champdict["rammus"], 4] = 2;
			championsRole[champdict["nunu"], 1] = 1;
			championsRole[champdict["nunu"], 4] = 2;
			championsRole[champdict["zilean"], 1] = 1;
			championsRole[champdict["zilean"], 3] = 2;
			championsRole[champdict["udyr"], 4] = 2;
			championsRole[champdict["singed"], 0] = 2;
			championsRole[champdict["annie"], 0] = 1;
			championsRole[champdict["annie"], 1] = 2;
			championsRole[champdict["annie"], 3] = 1;
			championsRole[champdict["kog'maw"], 0] = 1;
			championsRole[champdict["kog'maw"], 1] = 1;
			championsRole[champdict["kog'maw"], 3] = 2;
			championsRole[champdict["heimerdinger"], 0] = 1;
			championsRole[champdict["heimerdinger"], 1] = 2;
			championsRole[champdict["heimerdinger"], 3] = 1;
			championsRole[champdict["aurelionsol"], 0] = 1;
			championsRole[champdict["aurelionsol"], 1] = 2;
			championsRole[champdict["ivern"], 0] = 1;
			championsRole[champdict["ivern"], 3] = 1;
			championsRole[champdict["ivern"], 4] = 2;
			championsRole[champdict["quinn"], 0] = 1;
			championsRole[champdict["quinn"], 1] = 2;
			championsRole[champdict["shyvanna"], 0] = 1;
			championsRole[champdict["shyvanna"], 4] = 2;
			championsRole[champdict["tahmkench"], 0] = 2;
			championsRole[champdict["tahmkench"], 3] = 1;
			championsRole[champdict["yorick"], 0] = 2;
			championsRole[champdict["fiddlesticks"], 0] = 1;
			championsRole[champdict["fiddlesticks"], 1] = 1;
			championsRole[champdict["fiddlesticks"], 3] = 1;
			championsRole[champdict["fiddlesticks"], 4] = 2;
			championsRole[champdict["dr.mundo"], 0] = 2;
			championsRole[champdict["dr.mundo"], 4] = 1;
			championsRole[champdict["evelynn"], 4] = 2;
			championsRole[champdict["rengar"], 0] = 2;
			championsRole[champdict["rengar"], 4] = 1;
			championsRole[champdict["cho'gath"], 0] = 1;
			championsRole[champdict["cho'gath"], 1] = 2;
			championsRole[champdict["cho'gath"], 3] = 1;
			championsRole[champdict["cho'gath"], 4] = 1;
			championsRole[champdict["nasus"], 0] = 1;
			championsRole[champdict["nasus"], 1] = 1;
			championsRole[champdict["rek'sai"], 0] = 1;
			championsRole[champdict["rek'sai"], 4] = 2;
			championsRole[champdict["vi"], 4] = 2;
			championsRole[champdict["kled"], 0] = 1;
			championsRole[champdict["kled"], 1] = 1;
			championsRole[champdict["taliyah"], 1] = 1;
			championsRole[champdict["taliyah"], 3] = 1;
			championsRole[champdict["taliyah"], 4] = 1;
			championsRole[champdict["amumu"], 3] = 1;
			championsRole[champdict["amumu"], 4] = 2;
			championsRole[champdict["kayle"], 0] = 2;
			championsRole[champdict["kayle"], 1] = 1;
			championsRole[champdict["garen"], 0] = 2;
			championsRole[champdict["garen"], 1] = 1;
			championsRole[champdict["tryndamere"], 0] = 2;
			championsRole[champdict["tryndamere"], 1] = 1;
			championsRole[champdict["tryndamere"], 4] = 1;
			championsRole[champdict["azir"], 0] = 1;
			championsRole[champdict["azir"], 1] = 2;
			championsRole[champdict["ziggs"], 0] = 1;
			championsRole[champdict["ziggs"], 1] = 2;
			championsRole[champdict["ziggs"], 3] = 1;
			championsRole[champdict["wukong"], 0] = 1;
			championsRole[champdict["wukong"], 2] = 1;
			championsRole[champdict["wukong"], 4] = 2;
			championsRole[champdict["lissandra"], 0] = 1;
			championsRole[champdict["lissandra"], 2] = 2;
			championsRole[champdict["anivia"], 2] = 2;
			championsRole[champdict["olaf"], 0] = 1;
			championsRole[champdict["olaf"], 4] = 2;
			championsRole[champdict["braum"], 3] = 2;
			championsRole[champdict["galio"], 2] = 2;
			championsRole[champdict["galio"], 3] = 1;
			championsRole[champdict["poppy"], 0] = 2;
			championsRole[champdict["poppy"], 3] = 1;
			championsRole[champdict["poppy"], 4] = 1;
			championsRole[champdict["xinzhao"], 0] = 1;
			championsRole[champdict["xinzhao"], 2] = 1;
			championsRole[champdict["zac"], 0] = 1;
			championsRole[champdict["zac"], 3] = 1;
			championsRole[champdict["zac"], 4] = 2;
			championsRole[champdict["rumble"], 0] = 1;
			championsRole[champdict["rumble"], 2] = 2;
			championsRole[champdict["sion"], 0] = 2;
			championsRole[champdict["sion"], 2] = 1;
			championsRole[champdict["sion"], 3] = 1;
			championsRole[champdict["sion"], 4] = 1;
			championsRole[champdict["illaoi"], 0] = 2;
			championsRole[champdict["illaoi"], 2] = 1;
			championsRole[champdict["khazix"], 4] = 2;
			championsRole[champdict["masteryi"], 0] = 1;
			championsRole[champdict["masteryi"], 4] = 2;
			enterchamp = Console.ReadLine().Split(" ");

			 champScore = new int[10];
			for (int i = 0; i < 10; i++)
			{
				champScore[i] = champdict[enterchamp[i]];
			}

			 champtopmain = new int[10];
			 champtop = new int[10];
			contador = 0;
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 0] == 2)
				{
					champtopmain[i] = contador + 1;
					contador += 1;
				}
			}
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 0] == 1)
				{
					champtop[i] = contador + 1;
					Console.WriteLine(champScore[i]);
					Console.WriteLine(champtop[i]);
					contador += 1;
				}
			}

			divisor = 0;
			 notMains = 0;
			if (champtop[0] > 0 || champtopmain[0] > 0) { divisor += 1; }
			if (champtop[1] > 0 || champtopmain[1] > 0) { divisor += 1; }
			if (champtop[2] > 0 || champtopmain[2] > 0) { divisor += 1; }
			if (champtop[3] > 0 || champtopmain[3] > 0) { divisor += 1; }
			if (champtop[4] > 0 || champtopmain[4] > 0) { divisor += 1; }
			if (champtop[5] > 0 || champtopmain[5] > 0) { divisor += 1; }
			if (champtop[6] > 0 || champtopmain[6] > 0) { divisor += 1; }
			if (champtop[7] > 0 || champtopmain[7] > 0) { divisor += 1; }
			if (champtop[8] > 0 || champtopmain[8] > 0) { divisor += 1; }
			if (champtop[9] > 0 || champtopmain[9] > 0) { divisor += 1; }

			if (champtop[0] > 0) { notMains += 1; }
			if (champtop[1] > 0) { notMains += 1; }
			if (champtop[2] > 0) { notMains += 1; }
			if (champtop[3] > 0) { notMains += 1; }
			if (champtop[4] > 0) { notMains += 1; }
			if (champtop[5] > 0) { notMains += 1; }
			if (champtop[6] > 0) { notMains += 1; }
			if (champtop[7] > 0) { notMains += 1; }
			if (champtop[8] > 0) { notMains += 1; }
			if (champtop[9] > 0) { notMains += 1; }

			for (int i = 0; i < 10; i++)
			{
				if (champtopmain[i] == 1) { champdict[enterchamp[i]] += 100; }
				if (champtopmain[i] == 2) { champdict[enterchamp[i]] += 100 * (divisor - 1) / divisor; }
				if (champtopmain[i] == 3) { champdict[enterchamp[i]] += 100 * (divisor - 2) / divisor; }
				if (champtopmain[i] == 4) { champdict[enterchamp[i]] += 100 * (divisor - 3) / divisor; }
				if (champtopmain[i] == 5) { champdict[enterchamp[i]] += 100 * (divisor - 4) / divisor; }
				if (champtopmain[i] == 6) { champdict[enterchamp[i]] += 100 * (divisor - 5) / divisor; }
				if (champtopmain[i] == 7) { champdict[enterchamp[i]] += 100 * (divisor - 6) / divisor; }
				if (champtopmain[i] == 8) { champdict[enterchamp[i]] += 100 * (divisor - 7) / divisor; }
				if (champtopmain[i] == 9) { champdict[enterchamp[i]] += 100 * (divisor - 8) / divisor; }
				if (champtopmain[i] == 10) { champdict[enterchamp[i]] += 100 * (divisor - 9) / divisor; }
			}
			for (int i = 0; i < 10; i++)
			{
				if (champtop[i] == divisor - notMains + 1) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100) / divisor; }
				if (champtop[i] == divisor - notMains + 2) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 100) / divisor; }
				if (champtop[i] == divisor - notMains + 3) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 200) / divisor; }
				if (champtop[i] == divisor - notMains + 4) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 300) / divisor; }
				if (champtop[i] == divisor - notMains + 5) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 400) / divisor; }
				if (champtop[i] == divisor - notMains + 6) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 500) / divisor; }
				if (champtop[i] == divisor - notMains + 7) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 600) / divisor; }
				if (champtop[i] == divisor - notMains + 8) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 700) / divisor; }
				if (champtop[i] == divisor - notMains + 9) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 800) / divisor; }
				if (champtop[i] == divisor - notMains + 10) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 900) / divisor; }
			}

			 champmidmain = new int[10];
			 champmid = new int[10];
			contador = 0;
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 1] == 2)
				{
					champmidmain[i] = contador + 1;
					contador += 1;
				}
			}
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 1] == 1)
				{
					champmid[i] = contador + 1;
					contador += 1;
				}
			}

			divisor = 0;
			notMains = 0;
			if (champmid[0] > 0 || champmidmain[0] > 0) { divisor += 1; }
			if (champmid[1] > 0 || champmidmain[1] > 0) { divisor += 1; }
			if (champmid[2] > 0 || champmidmain[2] > 0) { divisor += 1; }
			if (champmid[3] > 0 || champmidmain[3] > 0) { divisor += 1; }
			if (champmid[4] > 0 || champmidmain[4] > 0) { divisor += 1; }
			if (champmid[5] > 0 || champmidmain[5] > 0) { divisor += 1; }
			if (champmid[6] > 0 || champmidmain[6] > 0) { divisor += 1; }
			if (champmid[7] > 0 || champmidmain[7] > 0) { divisor += 1; }
			if (champmid[8] > 0 || champmidmain[8] > 0) { divisor += 1; }
			if (champmid[9] > 0 || champmidmain[9] > 0) { divisor += 1; }

			if (champmid[0] > 0) { notMains += 1; }
			if (champmid[1] > 0) { notMains += 1; }
			if (champmid[2] > 0) { notMains += 1; }
			if (champmid[3] > 0) { notMains += 1; }
			if (champmid[4] > 0) { notMains += 1; }
			if (champmid[5] > 0) { notMains += 1; }
			if (champmid[6] > 0) { notMains += 1; }
			if (champmid[7] > 0) { notMains += 1; }
			if (champmid[8] > 0) { notMains += 1; }
			if (champmid[9] > 0) { notMains += 1; }

			for (int i = 0; i < 10; i++)
			{
				if (champmidmain[i] == 1) { champdict[enterchamp[i]] += 100; }
				if (champmidmain[i] == 2) { champdict[enterchamp[i]] += 100 * (divisor - 1) / divisor; }
				if (champmidmain[i] == 3) { champdict[enterchamp[i]] += 100 * (divisor - 2) / divisor; }
				if (champmidmain[i] == 4) { champdict[enterchamp[i]] += 100 * (divisor - 3) / divisor; }
				if (champmidmain[i] == 5) { champdict[enterchamp[i]] += 100 * (divisor - 4) / divisor; }
				if (champmidmain[i] == 6) { champdict[enterchamp[i]] += 100 * (divisor - 5) / divisor; }
				if (champmidmain[i] == 7) { champdict[enterchamp[i]] += 100 * (divisor - 6) / divisor; }
				if (champmidmain[i] == 8) { champdict[enterchamp[i]] += 100 * (divisor - 7) / divisor; }
				if (champmidmain[i] == 9) { champdict[enterchamp[i]] += 100 * (divisor - 8) / divisor; }
				if (champmidmain[i] == 10) { champdict[enterchamp[i]] += 100 * (divisor - 9) / divisor; }
			}
			for (int i = 0; i < 10; i++)
			{
				if (champmid[i] == divisor - notMains + 1) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100) / divisor; }
				if (champmid[i] == divisor - notMains + 2) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 100) / divisor; }
				if (champmid[i] == divisor - notMains + 3) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 200) / divisor; }
				if (champmid[i] == divisor - notMains + 4) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 300) / divisor; }
				if (champmid[i] == divisor - notMains + 5) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 400) / divisor; }
				if (champmid[i] == divisor - notMains + 6) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 500) / divisor; }
				if (champmid[i] == divisor - notMains + 7) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 600) / divisor; }
				if (champmid[i] == divisor - notMains + 8) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 700) / divisor; }
				if (champmid[i] == divisor - notMains + 9) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 800) / divisor; }
				if (champmid[i] == divisor - notMains + 10) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 900) / divisor; }
			}


			 champadcmain = new int[10];
			 champadc = new int[10];
			contador = 0;
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 2] == 2)
				{
					champadcmain[i] = contador + 1;
					contador += 1;
				}
			}
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 2] == 1)
				{
					champadc[i] = contador + 1;
					contador += 1;
				}
			}

			divisor = 0;
			notMains = 0;
			if (champadc[0] > 0 || champadcmain[0] > 0) { divisor += 1; }
			if (champadc[1] > 0 || champadcmain[1] > 0) { divisor += 1; }
			if (champadc[2] > 0 || champadcmain[2] > 0) { divisor += 1; }
			if (champadc[3] > 0 || champadcmain[3] > 0) { divisor += 1; }
			if (champadc[4] > 0 || champadcmain[4] > 0) { divisor += 1; }
			if (champadc[5] > 0 || champadcmain[5] > 0) { divisor += 1; }
			if (champadc[6] > 0 || champadcmain[6] > 0) { divisor += 1; }
			if (champadc[7] > 0 || champadcmain[7] > 0) { divisor += 1; }
			if (champadc[8] > 0 || champadcmain[8] > 0) { divisor += 1; }
			if (champadc[9] > 0 || champadcmain[9] > 0) { divisor += 1; }

			if (champadc[0] > 0) { notMains += 1; }
			if (champadc[1] > 0) { notMains += 1; }
			if (champadc[2] > 0) { notMains += 1; }
			if (champadc[3] > 0) { notMains += 1; }
			if (champadc[4] > 0) { notMains += 1; }
			if (champadc[5] > 0) { notMains += 1; }
			if (champadc[6] > 0) { notMains += 1; }
			if (champadc[7] > 0) { notMains += 1; }
			if (champadc[8] > 0) { notMains += 1; }
			if (champadc[9] > 0) { notMains += 1; }



			for (int i = 0; i < 10; i++)
			{
				if (champadcmain[i] == 1) { champdict[enterchamp[i]] += 100; }
				if (champadcmain[i] == 2) { champdict[enterchamp[i]] += 100 * (divisor - 1) / divisor; }
				if (champadcmain[i] == 3) { champdict[enterchamp[i]] += 100 * (divisor - 2) / divisor; }
				if (champadcmain[i] == 4) { champdict[enterchamp[i]] += 100 * (divisor - 3) / divisor; }
				if (champadcmain[i] == 5) { champdict[enterchamp[i]] += 100 * (divisor - 4) / divisor; }
				if (champadcmain[i] == 6) { champdict[enterchamp[i]] += 100 * (divisor - 5) / divisor; }
				if (champadcmain[i] == 7) { champdict[enterchamp[i]] += 100 * (divisor - 6) / divisor; }
				if (champadcmain[i] == 8) { champdict[enterchamp[i]] += 100 * (divisor - 7) / divisor; }
				if (champadcmain[i] == 9) { champdict[enterchamp[i]] += 100 * (divisor - 8) / divisor; }
				if (champadcmain[i] == 10) { champdict[enterchamp[i]] += 100 * (divisor - 9) / divisor; }
			}
			for (int i = 0; i < 10; i++)
			{
				if (champadc[i] == divisor - notMains + 1) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100) / divisor; }
				if (champadc[i] == divisor - notMains + 2) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 100) / divisor; }
				if (champadc[i] == divisor - notMains + 3) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 200) / divisor; }
				if (champadc[i] == divisor - notMains + 4) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 300) / divisor; }
				if (champadc[i] == divisor - notMains + 5) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 400) / divisor; }
				if (champadc[i] == divisor - notMains + 6) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 500) / divisor; }
				if (champadc[i] == divisor - notMains + 7) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 600) / divisor; }
				if (champadc[i] == divisor - notMains + 8) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 700) / divisor; }
				if (champadc[i] == divisor - notMains + 9) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 800) / divisor; }
				if (champadc[i] == divisor - notMains + 10)
				{
					champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 900) / divisor;
				}
			}
			 champsupmain = new int[10];
			 champsup = new int[10];
			contador = 0;
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 3] == 2)
				{
					champsupmain[i] = contador + 1;
					contador += 1;
				}
			}
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 3] == 1)
				{
					champsup[i] = contador + 1;
					contador += 1;
				}
			}

			divisor = 0;
			notMains = 0;
			if (champsup[0] > 0 || champsupmain[0] > 0) { divisor += 1; }
			if (champsup[1] > 0 || champsupmain[1] > 0) { divisor += 1; }
			if (champsup[2] > 0 || champsupmain[2] > 0) { divisor += 1; }
			if (champsup[3] > 0 || champsupmain[3] > 0) { divisor += 1; }
			if (champsup[4] > 0 || champsupmain[4] > 0) { divisor += 1; }
			if (champsup[5] > 0 || champsupmain[5] > 0) { divisor += 1; }
			if (champsup[6] > 0 || champsupmain[6] > 0) { divisor += 1; }
			if (champsup[7] > 0 || champsupmain[7] > 0) { divisor += 1; }
			if (champsup[8] > 0 || champsupmain[8] > 0) { divisor += 1; }
			if (champsup[9] > 0 || champsupmain[9] > 0) { divisor += 1; }

			if (champsup[0] > 0) { notMains += 1; }
			if (champsup[1] > 0) { notMains += 1; }
			if (champsup[2] > 0) { notMains += 1; }
			if (champsup[3] > 0) { notMains += 1; }
			if (champsup[4] > 0) { notMains += 1; }
			if (champsup[5] > 0) { notMains += 1; }
			if (champsup[6] > 0) { notMains += 1; }
			if (champsup[7] > 0) { notMains += 1; }
			if (champsup[8] > 0) { notMains += 1; }
			if (champsup[9] > 0) { notMains += 1; }



			for (int i = 0; i < 10; i++)
			{
				if (champsupmain[i] == 1) { champdict[enterchamp[i]] += 100; }
				if (champsupmain[i] == 2) { champdict[enterchamp[i]] += 100 * (divisor - 1) / divisor; }
				if (champsupmain[i] == 3) { champdict[enterchamp[i]] += 100 * (divisor - 2) / divisor; }
				if (champsupmain[i] == 4) { champdict[enterchamp[i]] += 100 * (divisor - 3) / divisor; }
				if (champsupmain[i] == 5) { champdict[enterchamp[i]] += 100 * (divisor - 4) / divisor; }
				if (champsupmain[i] == 6) { champdict[enterchamp[i]] += 100 * (divisor - 5) / divisor; }
				if (champsupmain[i] == 7) { champdict[enterchamp[i]] += 100 * (divisor - 6) / divisor; }
				if (champsupmain[i] == 8) { champdict[enterchamp[i]] += 100 * (divisor - 7) / divisor; }
				if (champsupmain[i] == 9) { champdict[enterchamp[i]] += 100 * (divisor - 8) / divisor; }
				if (champsupmain[i] == 10) { champdict[enterchamp[i]] += 100 * (divisor - 9) / divisor; }
			}
			for (int i = 0; i < 10; i++)
			{
				if (champsup[i] == divisor - notMains + 1) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100) / divisor; }
				if (champsup[i] == divisor - notMains + 2) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 100) / divisor; }
				if (champsup[i] == divisor - notMains + 3) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 200) / divisor; }
				if (champsup[i] == divisor - notMains + 4) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 300) / divisor; }
				if (champsup[i] == divisor - notMains + 5) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 400) / divisor; }
				if (champsup[i] == divisor - notMains + 6) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 500) / divisor; }
				if (champsup[i] == divisor - notMains + 7) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 600) / divisor; }
				if (champsup[i] == divisor - notMains + 8) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 700) / divisor; }
				if (champsup[i] == divisor - notMains + 9) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 800) / divisor; }
				if (champsup[i] == divisor - notMains + 10)
				{
					champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 900) / divisor;
				}
			}

			 champjgmain = new int[10];
			 champjg = new int[10];
			contador = 0;
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 4] == 2)
				{
					champjgmain[i] = contador + 1;
					contador += 1;
				}
			}
			for (int i = 0; i < 10; i++)
			{
				if (championsRole[champScore[i], 4] == 1)
				{
					champjg[i] = contador + 1;
					contador += 1;
				}
			}

			divisor = 0;
			notMains = 0;
			if (champjg[0] > 0 || champjgmain[0] > 0) { divisor += 1; }
			if (champjg[1] > 0 || champjgmain[1] > 0) { divisor += 1; }
			if (champjg[2] > 0 || champjgmain[2] > 0) { divisor += 1; }
			if (champjg[3] > 0 || champjgmain[3] > 0) { divisor += 1; }
			if (champjg[4] > 0 || champjgmain[4] > 0) { divisor += 1; }
			if (champjg[5] > 0 || champjgmain[5] > 0) { divisor += 1; }
			if (champjg[6] > 0 || champjgmain[6] > 0) { divisor += 1; }
			if (champjg[7] > 0 || champjgmain[7] > 0) { divisor += 1; }
			if (champjg[8] > 0 || champjgmain[8] > 0) { divisor += 1; }
			if (champjg[9] > 0 || champjgmain[9] > 0) { divisor += 1; }

			if (champjg[0] > 0) { notMains += 1; }
			if (champjg[1] > 0) { notMains += 1; }
			if (champjg[2] > 0) { notMains += 1; }
			if (champjg[3] > 0) { notMains += 1; }
			if (champjg[4] > 0) { notMains += 1; }
			if (champjg[5] > 0) { notMains += 1; }
			if (champjg[6] > 0) { notMains += 1; }
			if (champjg[7] > 0) { notMains += 1; }
			if (champjg[8] > 0) { notMains += 1; }
			if (champjg[9] > 0) { notMains += 1; }



			for (int i = 0; i < 10; i++)
			{
				if (champjgmain[i] == 1) { champdict[enterchamp[i]] += 100; }
				if (champjgmain[i] == 2) { champdict[enterchamp[i]] += 100 * (divisor - 1) / divisor; }
				if (champjgmain[i] == 3) { champdict[enterchamp[i]] += 100 * (divisor - 2) / divisor; }
				if (champjgmain[i] == 4) { champdict[enterchamp[i]] += 100 * (divisor - 3) / divisor; }
				if (champjgmain[i] == 5) { champdict[enterchamp[i]] += 100 * (divisor - 4) / divisor; }
				if (champjgmain[i] == 6) { champdict[enterchamp[i]] += 100 * (divisor - 5) / divisor; }
				if (champjgmain[i] == 7) { champdict[enterchamp[i]] += 100 * (divisor - 6) / divisor; }
				if (champjgmain[i] == 8) { champdict[enterchamp[i]] += 100 * (divisor - 7) / divisor; }
				if (champjgmain[i] == 9) { champdict[enterchamp[i]] += 100 * (divisor - 8) / divisor; }
				if (champjgmain[i] == 10) { champdict[enterchamp[i]] += 100 * (divisor - 9) / divisor; }
			}
			for (int i = 0; i < 10; i++)
			{
				if (champjg[i] == divisor - notMains + 1) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100) / divisor; }
				if (champjg[i] == divisor - notMains + 2) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 100) / divisor; }
				if (champjg[i] == divisor - notMains + 3) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 200) / divisor; }
				if (champjg[i] == divisor - notMains + 4) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 300) / divisor; }
				if (champjg[i] == divisor - notMains + 5) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 400) / divisor; }
				if (champjg[i] == divisor - notMains + 6) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 500) / divisor; }
				if (champjg[i] == divisor - notMains + 7) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 600) / divisor; }
				if (champjg[i] == divisor - notMains + 8) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 700) / divisor; }
				if (champjg[i] == divisor - notMains + 9) { champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 800) / divisor; }
				if (champjg[i] == divisor - notMains + 10)
				{
					champdict[enterchamp[i]] += ((divisor - (divisor - notMains)) * 100 - 900) / divisor;
				}
			}
			var sortedDict4 = from entry in champdict orderby entry.Value descending select entry;
			foreach (var x in sortedDict)
			{
				Console.WriteLine(x);
			}
			Console.ReadLine();
		}
	}
}
