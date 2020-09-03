using System;
using System.Collections.Generic;
using System.Linq;

namespace Monochampions_list
{
	class Program
	{
		static void Main(string[] args)
		{
			int top = 0;
			int mid = 1;
			int adc = 2;
			int sup = 3;
			int jg = 4;
			Dictionary<string, int> champdict = new Dictionary<string, int>();
			champdict.Add("skarner", 3700);
			champdict.Add("karthus", 3655);
			champdict.Add("swain", 3428);
			champdict.Add("rammus", 2887);
			champdict.Add("nunu", 2572);
			champdict.Add("urgot", 2330);
			champdict.Add("annie", 2029);
			champdict.Add("ivern", 1852);
			champdict.Add("singed", 1786);
			champdict.Add("hecarim", 1730);
			champdict.Add("zilean", 1395);
			champdict.Add("aurelionsol", 1317);
			champdict.Add("udyr", 1316);
			champdict.Add("kog'maw", 1306);
			champdict.Add("quinn", 1203);
			champdict.Add("yorick", 794);
			champdict.Add("heimerdinger", 710);
			champdict.Add("dr.mundo", 616);
			champdict.Add("shyvanna", 603);
			champdict.Add("tahmkench", 600);
			champdict.Add("galio", 599);
			champdict.Add("wukong", 576);
			champdict.Add("vi", 569);
			champdict.Add("sion", 562);
			champdict.Add("fiddlesticks", 514);
			champdict.Add("nasus", 474);
			champdict.Add("evelynn", 442);
			champdict.Add("warwick", 417);
			champdict.Add("tryndamere", 357);
			champdict.Add("rengar", 353);
			champdict.Add("cho'gath", 324);
			champdict.Add("anivia", 302);
			champdict.Add("olaf", 292);
			champdict.Add("rek'sai", 283);
			champdict.Add("lissandra", 262);
			champdict.Add("kled", 254);
			champdict.Add("amumu", 233);
			champdict.Add("poppy", 223);
			champdict.Add("xinzhao", 220);
			champdict.Add("malzahar", 188);
			champdict.Add("brand", 181);
			champdict.Add("taliyah", 175);
			champdict.Add("kayle", 163);
			champdict.Add("garen", 160);
			champdict.Add("masteryi", 153);
			champdict.Add("azir", 135);
			champdict.Add("ziggs", 134);
			champdict.Add("fiora", 129);
			champdict.Add("braum", 100);
			champdict.Add("zac", 84);
			champdict.Add("rumble", 80);
			champdict.Add("illaoi", 67);
			champdict.Add("khazix", 50);


			int[,] championsRole = new int[100000, 5];
			championsRole[champdict["karthus"], top] = 1;
			championsRole[champdict["fiora"], top] = 2;
			championsRole[champdict["fiora"], mid] = 1;
			championsRole[champdict["brand"], mid] = 2;
			championsRole[champdict["brand"], sup] = 1;
			championsRole[champdict["malzahar"], top] = 1;
			championsRole[champdict["malzahar"], mid] = 2;
			championsRole[champdict["malzahar"], adc] = 1;
			championsRole[champdict["malzahar"], sup] = 1;
			championsRole[champdict["karthus"], mid] = 1;
			championsRole[champdict["karthus"], adc] = 1;
			championsRole[champdict["karthus"], sup] = 1;
			championsRole[champdict["karthus"], jg] = 2;
			championsRole[champdict["skarner"], top] = 1;
			championsRole[champdict["skarner"], jg] = 2;
			championsRole[champdict["hecarim"], top] = 1;
			championsRole[champdict["hecarim"], jg] = 2;
			championsRole[champdict["swain"], top] = 1;
			championsRole[champdict["swain"], mid] = 2;
			championsRole[champdict["swain"], adc] = 1;
			championsRole[champdict["swain"], sup] = 1;
			championsRole[champdict["urgot"], top] = 2;
			championsRole[champdict["urgot"], mid] = 1;
			championsRole[champdict["rammus"], top] = 1;
			championsRole[champdict["rammus"], jg] = 2;
			championsRole[champdict["nunu"], mid] = 1;
			championsRole[champdict["nunu"], jg] = 2;
			championsRole[champdict["zilean"], mid] = 1;
			championsRole[champdict["zilean"], sup] = 2;
			championsRole[champdict["udyr"], jg] = 2;
			championsRole[champdict["singed"], top] = 2;
			championsRole[champdict["annie"], top] = 1;
			championsRole[champdict["annie"], mid] = 2;
			championsRole[champdict["annie"], sup] = 1;
			championsRole[champdict["kog'maw"], top] = 1;
			championsRole[champdict["kog'maw"], mid] = 1;
			championsRole[champdict["kog'maw"], adc] = 2;
			championsRole[champdict["heimerdinger"], top] = 1;
			championsRole[champdict["heimerdinger"], mid] = 2;
			championsRole[champdict["heimerdinger"], adc] = 1;
			championsRole[champdict["heimerdinger"], sup] = 1;
			championsRole[champdict["aurelionsol"], top] = 1;
			championsRole[champdict["aurelionsol"], mid] = 2;
			championsRole[champdict["ivern"], top] = 1;
			championsRole[champdict["ivern"], sup] = 1;
			championsRole[champdict["ivern"], jg] = 2;
			championsRole[champdict["quinn"], top] = 1;
			championsRole[champdict["quinn"], adc] = 1;
			championsRole[champdict["quinn"], mid] = 2;
			championsRole[champdict["shyvanna"], top] = 1;
			championsRole[champdict["shyvanna"], jg] = 2;
			championsRole[champdict["tahmkench"], top] = 2;
			championsRole[champdict["tahmkench"], sup] = 1;
			championsRole[champdict["yorick"], top] = 2;
			championsRole[champdict["fiddlesticks"], top] = 1;
			championsRole[champdict["fiddlesticks"], mid] = 1;
			championsRole[champdict["fiddlesticks"], sup] = 1;
			championsRole[champdict["fiddlesticks"], jg] = 2;
			championsRole[champdict["dr.mundo"], top] = 2;
			championsRole[champdict["dr.mundo"], jg] = 1;
			championsRole[champdict["evelynn"], jg] = 2;
			championsRole[champdict["rengar"], top] = 2;
			championsRole[champdict["rengar"], jg] = 1;
			championsRole[champdict["cho'gath"], top] = 1;
			championsRole[champdict["cho'gath"], mid] = 2;
			championsRole[champdict["cho'gath"], sup] = 1;
			championsRole[champdict["cho'gath"], jg] = 1;
			championsRole[champdict["nasus"], top] = 2;
			championsRole[champdict["nasus"], mid] = 1;
			championsRole[champdict["rek'sai"], top] = 1;
			championsRole[champdict["rek'sai"], jg] = 2;
			championsRole[champdict["vi"], jg] = 2;
			championsRole[champdict["kled"], top] = 2;
			championsRole[champdict["kled"], mid] = 1;
			championsRole[champdict["taliyah"], mid] = 1;
			championsRole[champdict["taliyah"], adc] = 2;
			championsRole[champdict["taliyah"], sup] = 1;
			championsRole[champdict["taliyah"], jg] = 1;
			championsRole[champdict["amumu"], sup] = 1;
			championsRole[champdict["amumu"], jg] = 2;
			championsRole[champdict["kayle"], top] = 2;
			championsRole[champdict["kayle"], mid] = 1;
			championsRole[champdict["garen"], top] = 2;
			championsRole[champdict["garen"], mid] = 1;
			championsRole[champdict["warwick"], jg] = 2;
			championsRole[champdict["tryndamere"], top] = 2;
			championsRole[champdict["tryndamere"], mid] = 1;
			championsRole[champdict["tryndamere"], jg] = 1;
			championsRole[champdict["azir"], top] = 1;
			championsRole[champdict["azir"], adc] = 1;
			championsRole[champdict["azir"], mid] = 2;
			championsRole[champdict["ziggs"], top] = 1;
			championsRole[champdict["ziggs"], mid] = 2;
			championsRole[champdict["ziggs"], sup] = 1;
			championsRole[champdict["ziggs"], adc] = 1;
			championsRole[champdict["wukong"], top] = 1;
			championsRole[champdict["wukong"], mid] = 1;
			championsRole[champdict["wukong"], jg] = 2;
			championsRole[champdict["lissandra"], top] = 1;
			championsRole[champdict["lissandra"], mid] = 2;
			championsRole[champdict["lissandra"], sup] = 1;
			championsRole[champdict["anivia"], mid] = 2;
			championsRole[champdict["olaf"], top] = 1;
			championsRole[champdict["olaf"], jg] = 2;
			championsRole[champdict["braum"], sup] = 2;
			championsRole[champdict["galio"], mid] = 2;
			championsRole[champdict["galio"], sup] = 1;
			championsRole[champdict["poppy"], top] = 2;
			championsRole[champdict["poppy"], sup] = 1;
			championsRole[champdict["poppy"], jg] = 1;
			championsRole[champdict["xinzhao"], top] = 1;
			championsRole[champdict["xinzhao"], mid] = 1;
			championsRole[champdict["xinzhao"], jg] = 2;
			championsRole[champdict["zac"], top] = 1;
			championsRole[champdict["zac"], sup] = 1;
			championsRole[champdict["zac"], jg] = 2;
			championsRole[champdict["rumble"], top] = 1;
			championsRole[champdict["rumble"], mid] = 2;
			championsRole[champdict["sion"], top] = 2;
			championsRole[champdict["sion"], mid] = 1;
			championsRole[champdict["sion"], sup] = 1;
			championsRole[champdict["sion"], jg] = 1;
			championsRole[champdict["illaoi"], top] = 2;
			championsRole[champdict["illaoi"], mid] = 1;
			championsRole[champdict["khazix"], jg] = 2;
			championsRole[champdict["masteryi"], top] = 1;
			championsRole[champdict["masteryi"], jg] = 2;

			Console.WriteLine("BRONZE:");
			string[] enterchamp = Console.ReadLine().Split(" ");

			;
			int[] champScore = new int[10];
			for (int i = 0; i < 10; i++)
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

			var sortedDict = from entry in champdict orderby entry.Value descending select entry;
			foreach (var x in sortedDict)
			{
				Console.WriteLine(x);
			}


			Console.WriteLine("PRATA:");
			championsRole = new int[100000, 5];
			championsRole[champdict["karthus"], top] = 1;
			championsRole[champdict["fiora"], top] = 2;
			championsRole[champdict["fiora"], mid] = 1;
			championsRole[champdict["brand"], mid] = 2;
			championsRole[champdict["brand"], sup] = 1;
			championsRole[champdict["malzahar"], top] = 1;
			championsRole[champdict["malzahar"], mid] = 2;
			championsRole[champdict["malzahar"], adc] = 1;
			championsRole[champdict["malzahar"], sup] = 1;
			championsRole[champdict["karthus"], mid] = 1;
			championsRole[champdict["karthus"], adc] = 1;
			championsRole[champdict["karthus"], sup] = 1;
			championsRole[champdict["karthus"], jg] = 2;
			championsRole[champdict["skarner"], top] = 1;
			championsRole[champdict["skarner"], jg] = 2;
			championsRole[champdict["hecarim"], top] = 1;
			championsRole[champdict["hecarim"], jg] = 2;
			championsRole[champdict["swain"], top] = 1;
			championsRole[champdict["swain"], mid] = 2;
			championsRole[champdict["swain"], adc] = 1;
			championsRole[champdict["swain"], sup] = 1;
			championsRole[champdict["urgot"], top] = 2;
			championsRole[champdict["urgot"], mid] = 1;
			championsRole[champdict["rammus"], top] = 1;
			championsRole[champdict["rammus"], jg] = 2;
			championsRole[champdict["nunu"], mid] = 1;
			championsRole[champdict["nunu"], jg] = 2;
			championsRole[champdict["zilean"], mid] = 1;
			championsRole[champdict["zilean"], sup] = 2;
			championsRole[champdict["udyr"], jg] = 2;
			championsRole[champdict["singed"], top] = 2;
			championsRole[champdict["annie"], top] = 1;
			championsRole[champdict["annie"], mid] = 2;
			championsRole[champdict["annie"], sup] = 1;
			championsRole[champdict["kog'maw"], top] = 1;
			championsRole[champdict["kog'maw"], mid] = 1;
			championsRole[champdict["kog'maw"], adc] = 2;
			championsRole[champdict["heimerdinger"], top] = 1;
			championsRole[champdict["heimerdinger"], mid] = 2;
			championsRole[champdict["heimerdinger"], adc] = 1;
			championsRole[champdict["heimerdinger"], sup] = 1;
			championsRole[champdict["aurelionsol"], top] = 1;
			championsRole[champdict["aurelionsol"], mid] = 2;
			championsRole[champdict["ivern"], top] = 1;
			championsRole[champdict["ivern"], sup] = 1;
			championsRole[champdict["ivern"], jg] = 2;
			championsRole[champdict["quinn"], top] = 1;
			championsRole[champdict["quinn"], adc] = 1;
			championsRole[champdict["quinn"], mid] = 2;
			championsRole[champdict["shyvanna"], top] = 1;
			championsRole[champdict["shyvanna"], jg] = 2;
			championsRole[champdict["tahmkench"], top] = 2;
			championsRole[champdict["tahmkench"], sup] = 1;
			championsRole[champdict["yorick"], top] = 2;
			championsRole[champdict["fiddlesticks"], top] = 1;
			championsRole[champdict["fiddlesticks"], mid] = 1;
			championsRole[champdict["fiddlesticks"], sup] = 1;
			championsRole[champdict["fiddlesticks"], jg] = 2;
			championsRole[champdict["dr.mundo"], top] = 2;
			championsRole[champdict["dr.mundo"], jg] = 1;
			championsRole[champdict["evelynn"], jg] = 2;
			championsRole[champdict["rengar"], top] = 2;
			championsRole[champdict["rengar"], jg] = 1;
			championsRole[champdict["cho'gath"], top] = 1;
			championsRole[champdict["cho'gath"], mid] = 2;
			championsRole[champdict["cho'gath"], sup] = 1;
			championsRole[champdict["cho'gath"], jg] = 1;
			championsRole[champdict["nasus"], top] = 2;
			championsRole[champdict["nasus"], mid] = 1;
			championsRole[champdict["rek'sai"], top] = 1;
			championsRole[champdict["rek'sai"], jg] = 2;
			championsRole[champdict["vi"], jg] = 2;
			championsRole[champdict["kled"], top] = 2;
			championsRole[champdict["kled"], mid] = 1;
			championsRole[champdict["taliyah"], mid] = 1;
			championsRole[champdict["taliyah"], adc] = 2;
			championsRole[champdict["taliyah"], sup] = 1;
			championsRole[champdict["taliyah"], jg] = 1;
			championsRole[champdict["amumu"], sup] = 1;
			championsRole[champdict["amumu"], jg] = 2;
			championsRole[champdict["kayle"], top] = 2;
			championsRole[champdict["kayle"], mid] = 1;
			championsRole[champdict["garen"], top] = 2;
			championsRole[champdict["garen"], mid] = 1;
			championsRole[champdict["warwick"], jg] = 2;
			championsRole[champdict["tryndamere"], top] = 2;
			championsRole[champdict["tryndamere"], mid] = 1;
			championsRole[champdict["tryndamere"], jg] = 1;
			championsRole[champdict["azir"], top] = 1;
			championsRole[champdict["azir"], adc] = 1;
			championsRole[champdict["azir"], mid] = 2;
			championsRole[champdict["ziggs"], top] = 1;
			championsRole[champdict["ziggs"], mid] = 2;
			championsRole[champdict["ziggs"], sup] = 1;
			championsRole[champdict["ziggs"], adc] = 1;
			championsRole[champdict["wukong"], top] = 1;
			championsRole[champdict["wukong"], mid] = 1;
			championsRole[champdict["wukong"], jg] = 2;
			championsRole[champdict["lissandra"], top] = 1;
			championsRole[champdict["lissandra"], mid] = 2;
			championsRole[champdict["lissandra"], sup] = 1;
			championsRole[champdict["anivia"], mid] = 2;
			championsRole[champdict["olaf"], top] = 1;
			championsRole[champdict["olaf"], jg] = 2;
			championsRole[champdict["braum"], sup] = 2;
			championsRole[champdict["galio"], mid] = 2;
			championsRole[champdict["galio"], sup] = 1;
			championsRole[champdict["poppy"], top] = 2;
			championsRole[champdict["poppy"], sup] = 1;
			championsRole[champdict["poppy"], jg] = 1;
			championsRole[champdict["xinzhao"], top] = 1;
			championsRole[champdict["xinzhao"], mid] = 1;
			championsRole[champdict["xinzhao"], jg] = 2;
			championsRole[champdict["zac"], top] = 1;
			championsRole[champdict["zac"], sup] = 1;
			championsRole[champdict["zac"], jg] = 2;
			championsRole[champdict["rumble"], top] = 1;
			championsRole[champdict["rumble"], mid] = 2;
			championsRole[champdict["sion"], top] = 2;
			championsRole[champdict["sion"], mid] = 1;
			championsRole[champdict["sion"], sup] = 1;
			championsRole[champdict["sion"], jg] = 1;
			championsRole[champdict["illaoi"], top] = 2;
			championsRole[champdict["illaoi"], mid] = 1;
			championsRole[champdict["khazix"], jg] = 2;
			championsRole[champdict["masteryi"], top] = 1;
			championsRole[champdict["masteryi"], jg] = 2;
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
			championsRole = new int[100000, 5];
			championsRole[champdict["karthus"], top] = 1;
			championsRole[champdict["fiora"], top] = 2;
			championsRole[champdict["fiora"], mid] = 1;
			championsRole[champdict["brand"], mid] = 2;
			championsRole[champdict["brand"], sup] = 1;
			championsRole[champdict["malzahar"], top] = 1;
			championsRole[champdict["malzahar"], mid] = 2;
			championsRole[champdict["malzahar"], adc] = 1;
			championsRole[champdict["malzahar"], sup] = 1;
			championsRole[champdict["karthus"], mid] = 1;
			championsRole[champdict["karthus"], adc] = 1;
			championsRole[champdict["karthus"], sup] = 1;
			championsRole[champdict["karthus"], jg] = 2;
			championsRole[champdict["skarner"], top] = 1;
			championsRole[champdict["skarner"], jg] = 2;
			championsRole[champdict["hecarim"], top] = 1;
			championsRole[champdict["hecarim"], jg] = 2;
			championsRole[champdict["swain"], top] = 1;
			championsRole[champdict["swain"], mid] = 2;
			championsRole[champdict["swain"], adc] = 1;
			championsRole[champdict["swain"], sup] = 1;
			championsRole[champdict["urgot"], top] = 2;
			championsRole[champdict["urgot"], mid] = 1;
			championsRole[champdict["rammus"], top] = 1;
			championsRole[champdict["rammus"], jg] = 2;
			championsRole[champdict["nunu"], mid] = 1;
			championsRole[champdict["nunu"], jg] = 2;
			championsRole[champdict["zilean"], mid] = 1;
			championsRole[champdict["zilean"], sup] = 2;
			championsRole[champdict["udyr"], jg] = 2;
			championsRole[champdict["singed"], top] = 2;
			championsRole[champdict["annie"], top] = 1;
			championsRole[champdict["annie"], mid] = 2;
			championsRole[champdict["annie"], sup] = 1;
			championsRole[champdict["kog'maw"], top] = 1;
			championsRole[champdict["kog'maw"], mid] = 1;
			championsRole[champdict["kog'maw"], adc] = 2;
			championsRole[champdict["heimerdinger"], top] = 1;
			championsRole[champdict["heimerdinger"], mid] = 2;
			championsRole[champdict["heimerdinger"], adc] = 1;
			championsRole[champdict["heimerdinger"], sup] = 1;
			championsRole[champdict["aurelionsol"], top] = 1;
			championsRole[champdict["aurelionsol"], mid] = 2;
			championsRole[champdict["ivern"], top] = 1;
			championsRole[champdict["ivern"], sup] = 1;
			championsRole[champdict["ivern"], jg] = 2;
			championsRole[champdict["quinn"], top] = 1;
			championsRole[champdict["quinn"], adc] = 1;
			championsRole[champdict["quinn"], mid] = 2;
			championsRole[champdict["shyvanna"], top] = 1;
			championsRole[champdict["shyvanna"], jg] = 2;
			championsRole[champdict["tahmkench"], top] = 2;
			championsRole[champdict["tahmkench"], sup] = 1;
			championsRole[champdict["yorick"], top] = 2;
			championsRole[champdict["fiddlesticks"], top] = 1;
			championsRole[champdict["fiddlesticks"], mid] = 1;
			championsRole[champdict["fiddlesticks"], sup] = 1;
			championsRole[champdict["fiddlesticks"], jg] = 2;
			championsRole[champdict["dr.mundo"], top] = 2;
			championsRole[champdict["dr.mundo"], jg] = 1;
			championsRole[champdict["evelynn"], jg] = 2;
			championsRole[champdict["rengar"], top] = 2;
			championsRole[champdict["rengar"], jg] = 1;
			championsRole[champdict["cho'gath"], top] = 1;
			championsRole[champdict["cho'gath"], mid] = 2;
			championsRole[champdict["cho'gath"], sup] = 1;
			championsRole[champdict["cho'gath"], jg] = 1;
			championsRole[champdict["nasus"], top] = 2;
			championsRole[champdict["nasus"], mid] = 1;
			championsRole[champdict["rek'sai"], top] = 1;
			championsRole[champdict["rek'sai"], jg] = 2;
			championsRole[champdict["vi"], jg] = 2;
			championsRole[champdict["kled"], top] = 2;
			championsRole[champdict["kled"], mid] = 1;
			championsRole[champdict["taliyah"], mid] = 1;
			championsRole[champdict["taliyah"], adc] = 2;
			championsRole[champdict["taliyah"], sup] = 1;
			championsRole[champdict["taliyah"], jg] = 1;
			championsRole[champdict["amumu"], sup] = 1;
			championsRole[champdict["amumu"], jg] = 2;
			championsRole[champdict["kayle"], top] = 2;
			championsRole[champdict["kayle"], mid] = 1;
			championsRole[champdict["garen"], top] = 2;
			championsRole[champdict["garen"], mid] = 1;
			championsRole[champdict["warwick"], jg] = 2;
			championsRole[champdict["tryndamere"], top] = 2;
			championsRole[champdict["tryndamere"], mid] = 1;
			championsRole[champdict["tryndamere"], jg] = 1;
			championsRole[champdict["azir"], top] = 1;
			championsRole[champdict["azir"], adc] = 1;
			championsRole[champdict["azir"], mid] = 2;
			championsRole[champdict["ziggs"], top] = 1;
			championsRole[champdict["ziggs"], mid] = 2;
			championsRole[champdict["ziggs"], sup] = 1;
			championsRole[champdict["ziggs"], adc] = 1;
			championsRole[champdict["wukong"], top] = 1;
			championsRole[champdict["wukong"], mid] = 1;
			championsRole[champdict["wukong"], jg] = 2;
			championsRole[champdict["lissandra"], top] = 1;
			championsRole[champdict["lissandra"], mid] = 2;
			championsRole[champdict["lissandra"], sup] = 1;
			championsRole[champdict["anivia"], mid] = 2;
			championsRole[champdict["olaf"], top] = 1;
			championsRole[champdict["olaf"], jg] = 2;
			championsRole[champdict["braum"], sup] = 2;
			championsRole[champdict["galio"], mid] = 2;
			championsRole[champdict["galio"], sup] = 1;
			championsRole[champdict["poppy"], top] = 2;
			championsRole[champdict["poppy"], sup] = 1;
			championsRole[champdict["poppy"], jg] = 1;
			championsRole[champdict["xinzhao"], top] = 1;
			championsRole[champdict["xinzhao"], mid] = 1;
			championsRole[champdict["xinzhao"], jg] = 2;
			championsRole[champdict["zac"], top] = 1;
			championsRole[champdict["zac"], sup] = 1;
			championsRole[champdict["zac"], jg] = 2;
			championsRole[champdict["rumble"], top] = 1;
			championsRole[champdict["rumble"], mid] = 2;
			championsRole[champdict["sion"], top] = 2;
			championsRole[champdict["sion"], mid] = 1;
			championsRole[champdict["sion"], sup] = 1;
			championsRole[champdict["sion"], jg] = 1;
			championsRole[champdict["illaoi"], top] = 2;
			championsRole[champdict["illaoi"], mid] = 1;
			championsRole[champdict["khazix"], jg] = 2;
			championsRole[champdict["masteryi"], top] = 1;
			championsRole[champdict["masteryi"], jg] = 2;
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
			int[,] championsrole2 = new int[100000, 5];
			championsrole2[champdict["karthus"], top] = 1;
			championsrole2[champdict["fiora"], top] = 2;
			championsrole2[champdict["fiora"], mid] = 1;
			championsrole2[champdict["brand"], mid] = 2;
			championsrole2[champdict["brand"], sup] = 1;
			championsrole2[champdict["malzahar"], top] = 1;
			championsrole2[champdict["malzahar"], mid] = 2;
			championsrole2[champdict["malzahar"], adc] = 1;
			championsrole2[champdict["malzahar"], sup] = 1;
			championsrole2[champdict["karthus"], mid] = 1;
			championsrole2[champdict["karthus"], adc] = 1;
			championsrole2[champdict["karthus"], sup] = 1;
			championsrole2[champdict["karthus"], jg] = 2;
			championsrole2[champdict["skarner"], top] = 1;
			championsrole2[champdict["skarner"], jg] = 2;
			championsrole2[champdict["hecarim"], top] = 1;
			championsrole2[champdict["hecarim"], jg] = 2;
			championsrole2[champdict["swain"], top] = 1;
			championsrole2[champdict["swain"], mid] = 2;
			championsrole2[champdict["swain"], adc] = 1;
			championsrole2[champdict["swain"], sup] = 1;
			championsrole2[champdict["urgot"], top] = 2;
			championsrole2[champdict["urgot"], mid] = 1;
			championsrole2[champdict["rammus"], top] = 1;
			championsrole2[champdict["rammus"], jg] = 2;
			championsrole2[champdict["nunu"], mid] = 1;
			championsrole2[champdict["nunu"], jg] = 2;
			championsrole2[champdict["zilean"], mid] = 1;
			championsrole2[champdict["zilean"], sup] = 2;
			championsrole2[champdict["udyr"], jg] = 2;
			championsrole2[champdict["singed"], top] = 2;
			championsrole2[champdict["annie"], top] = 1;
			championsrole2[champdict["annie"], mid] = 2;
			championsrole2[champdict["annie"], sup] = 1;
			championsrole2[champdict["kog'maw"], top] = 1;
			championsrole2[champdict["kog'maw"], mid] = 1;
			championsrole2[champdict["kog'maw"], adc] = 2;
			championsrole2[champdict["heimerdinger"], top] = 1;
			championsrole2[champdict["heimerdinger"], mid] = 2;
			championsrole2[champdict["heimerdinger"], adc] = 1;
			championsrole2[champdict["heimerdinger"], sup] = 1;
			championsrole2[champdict["aurelionsol"], top] = 1;
			championsrole2[champdict["aurelionsol"], mid] = 2;
			championsrole2[champdict["ivern"], top] = 1;
			championsrole2[champdict["ivern"], sup] = 1;
			championsrole2[champdict["ivern"], jg] = 2;
			championsrole2[champdict["quinn"], top] = 1;
			championsrole2[champdict["quinn"], adc] = 1;
			championsrole2[champdict["quinn"], mid] = 2;
			championsrole2[champdict["shyvanna"], top] = 1;
			championsrole2[champdict["shyvanna"], jg] = 2;
			championsrole2[champdict["tahmkench"], top] = 2;
			championsrole2[champdict["tahmkench"], sup] = 1;
			championsrole2[champdict["yorick"], top] = 2;
			championsrole2[champdict["fiddlesticks"], top] = 1;
			championsrole2[champdict["fiddlesticks"], mid] = 1;
			championsrole2[champdict["fiddlesticks"], sup] = 1;
			championsrole2[champdict["fiddlesticks"], jg] = 2;
			championsrole2[champdict["dr.mundo"], top] = 2;
			championsrole2[champdict["dr.mundo"], jg] = 1;
			championsrole2[champdict["evelynn"], jg] = 2;
			championsrole2[champdict["rengar"], top] = 2;
			championsrole2[champdict["rengar"], jg] = 1;
			championsrole2[champdict["cho'gath"], top] = 1;
			championsrole2[champdict["cho'gath"], mid] = 2;
			championsrole2[champdict["cho'gath"], sup] = 1;
			championsrole2[champdict["cho'gath"], jg] = 1;
			championsrole2[champdict["nasus"], top] = 2;
			championsrole2[champdict["nasus"], mid] = 1;
			championsrole2[champdict["rek'sai"], top] = 1;
			championsrole2[champdict["rek'sai"], jg] = 2;
			championsrole2[champdict["vi"], jg] = 2;
			championsrole2[champdict["kled"], top] = 2;
			championsrole2[champdict["kled"], mid] = 1;
			championsrole2[champdict["taliyah"], mid] = 1;
			championsrole2[champdict["taliyah"], adc] = 2;
			championsrole2[champdict["taliyah"], sup] = 1;
			championsrole2[champdict["taliyah"], jg] = 1;
			championsrole2[champdict["amumu"], sup] = 1;
			championsrole2[champdict["amumu"], jg] = 2;
			championsrole2[champdict["kayle"], top] = 2;
			championsrole2[champdict["kayle"], mid] = 1;
			championsrole2[champdict["garen"], top] = 2;
			championsrole2[champdict["garen"], mid] = 1;
			championsrole2[champdict["warwick"], jg] = 2;
			championsrole2[champdict["tryndamere"], top] = 2;
			championsrole2[champdict["tryndamere"], mid] = 1;
			championsrole2[champdict["tryndamere"], jg] = 1;
			championsrole2[champdict["azir"], top] = 1;
			championsrole2[champdict["azir"], adc] = 1;
			championsrole2[champdict["azir"], mid] = 2;
			championsrole2[champdict["ziggs"], top] = 1;
			championsrole2[champdict["ziggs"], mid] = 2;
			championsrole2[champdict["ziggs"], sup] = 1;
			championsrole2[champdict["ziggs"], adc] = 1;
			championsrole2[champdict["wukong"], top] = 1;
			championsrole2[champdict["wukong"], mid] = 1;
			championsrole2[champdict["wukong"], jg] = 2;
			championsrole2[champdict["lissandra"], top] = 1;
			championsrole2[champdict["lissandra"], mid] = 2;
			championsrole2[champdict["lissandra"], sup] = 1;
			championsrole2[champdict["anivia"], mid] = 2;
			championsrole2[champdict["olaf"], top] = 1;
			championsrole2[champdict["olaf"], jg] = 2;
			championsrole2[champdict["braum"], sup] = 2;
			championsrole2[champdict["galio"], mid] = 2;
			championsrole2[champdict["galio"], sup] = 1;
			championsrole2[champdict["poppy"], top] = 2;
			championsrole2[champdict["poppy"], sup] = 1;
			championsrole2[champdict["poppy"], jg] = 1;
			championsrole2[champdict["xinzhao"], top] = 1;
			championsrole2[champdict["xinzhao"], mid] = 1;
			championsrole2[champdict["xinzhao"], jg] = 2;
			championsrole2[champdict["zac"], top] = 1;
			championsrole2[champdict["zac"], sup] = 1;
			championsrole2[champdict["zac"], jg] = 2;
			championsrole2[champdict["rumble"], top] = 1;
			championsrole2[champdict["rumble"], mid] = 2;
			championsrole2[champdict["sion"], top] = 2;
			championsrole2[champdict["sion"], mid] = 1;
			championsrole2[champdict["sion"], sup] = 1;
			championsrole2[champdict["sion"], jg] = 1;
			championsrole2[champdict["illaoi"], top] = 2;
			championsrole2[champdict["illaoi"], mid] = 1;
			championsrole2[champdict["khazix"], jg] = 2;
			championsrole2[champdict["masteryi"], top] = 1;
			championsrole2[champdict["masteryi"], jg] = 2;
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
				if (championsrole2[champScore[i], 0] == 2)
				{
					champtopmain[i] = contador + 1;
					contador += 1;
				}
			}
			for (int i = 0; i < 10; i++)
			{
				if (championsrole2[champScore[i], 0] == 1)
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
				if (championsrole2[champScore[i], 2] == 2)
				{
					champadcmain[i] = contador + 1;
					contador += 1;
				}
			}
			for (int i = 0; i < 10; i++)
			{
				if (championsrole2[champScore[i], 2] == 1)
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
				if (championsrole2[champScore[i], 3] == 2)
				{
					champsupmain[i] = contador + 1;
					contador += 1;
				}
			}
			for (int i = 0; i < 10; i++)
			{
				if (championsrole2[champScore[i], 3] == 1)
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
				if (championsrole2[champScore[i], 4] == 2)
				{
					champjgmain[i] = contador + 1;
					contador += 1;
				}
			}
			for (int i = 0; i < 10; i++)
			{
				if (championsrole2[champScore[i], 4] == 1)
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


			var res = champdict.GroupBy(p => p.Value).ToDictionary(g => g.Key, g => g.Select(pp => pp.Key));
			foreach (var x in sortedDict)
			{
				Console.WriteLine(x);
			}

			string[] roles = new string[5];
			roles[0] = "Top:";
			roles[1] = "Mid:";
			roles[2] = "ADC:";
			roles[3] = "Sup:";
			roles[4] = "Jg:";
			List<string> champions = new List<string>();
			championsrole2 = new int[100000, 5];
			championsrole2[champdict["karthus"], top] = 1;
			championsrole2[champdict["fiora"], top] = 2;
			championsrole2[champdict["fiora"], mid] = 1;
			championsrole2[champdict["brand"], mid] = 2;
			championsrole2[champdict["brand"], sup] = 1;
			championsrole2[champdict["malzahar"], top] = 1;
			championsrole2[champdict["malzahar"], mid] = 2;
			championsrole2[champdict["malzahar"], adc] = 1;
			championsrole2[champdict["malzahar"], sup] = 1;
			championsrole2[champdict["karthus"], mid] = 1;
			championsrole2[champdict["karthus"], adc] = 1;
			championsrole2[champdict["karthus"], sup] = 1;
			championsrole2[champdict["karthus"], jg] = 2;
			championsrole2[champdict["skarner"], top] = 1;
			championsrole2[champdict["skarner"], jg] = 2;
			championsrole2[champdict["hecarim"], top] = 1;
			championsrole2[champdict["hecarim"], jg] = 2;
			championsrole2[champdict["swain"], top] = 1;
			championsrole2[champdict["swain"], mid] = 2;
			championsrole2[champdict["swain"], adc] = 1;
			championsrole2[champdict["swain"], sup] = 1;
			championsrole2[champdict["urgot"], top] = 2;
			championsrole2[champdict["urgot"], mid] = 1;
			championsrole2[champdict["rammus"], top] = 1;
			championsrole2[champdict["rammus"], jg] = 2;
			championsrole2[champdict["nunu"], mid] = 1;
			championsrole2[champdict["nunu"], jg] = 2;
			championsrole2[champdict["zilean"], mid] = 1;
			championsrole2[champdict["zilean"], sup] = 2;
			championsrole2[champdict["udyr"], jg] = 2;
			championsrole2[champdict["singed"], top] = 2;
			championsrole2[champdict["annie"], top] = 1;
			championsrole2[champdict["annie"], mid] = 2;
			championsrole2[champdict["annie"], sup] = 1;
			championsrole2[champdict["kog'maw"], top] = 1;
			championsrole2[champdict["kog'maw"], mid] = 1;
			championsrole2[champdict["kog'maw"], adc] = 2;
			championsrole2[champdict["heimerdinger"], top] = 1;
			championsrole2[champdict["heimerdinger"], mid] = 2;
			championsrole2[champdict["heimerdinger"], adc] = 1;
			championsrole2[champdict["heimerdinger"], sup] = 1;
			championsrole2[champdict["aurelionsol"], top] = 1;
			championsrole2[champdict["aurelionsol"], mid] = 2;
			championsrole2[champdict["ivern"], top] = 1;
			championsrole2[champdict["ivern"], sup] = 1;
			championsrole2[champdict["ivern"], jg] = 2;
			championsrole2[champdict["quinn"], top] = 1;
			championsrole2[champdict["quinn"], adc] = 1;
			championsrole2[champdict["quinn"], mid] = 2;
			championsrole2[champdict["shyvanna"], top] = 1;
			championsrole2[champdict["shyvanna"], jg] = 2;
			championsrole2[champdict["tahmkench"], top] = 2;
			championsrole2[champdict["tahmkench"], sup] = 1;
			championsrole2[champdict["yorick"], top] = 2;
			championsrole2[champdict["fiddlesticks"], top] = 1;
			championsrole2[champdict["fiddlesticks"], mid] = 1;
			championsrole2[champdict["fiddlesticks"], sup] = 1;
			championsrole2[champdict["fiddlesticks"], jg] = 2;
			championsrole2[champdict["dr.mundo"], top] = 2;
			championsrole2[champdict["dr.mundo"], jg] = 1;
			championsrole2[champdict["evelynn"], jg] = 2;
			championsrole2[champdict["rengar"], top] = 2;
			championsrole2[champdict["rengar"], jg] = 1;
			championsrole2[champdict["cho'gath"], top] = 1;
			championsrole2[champdict["cho'gath"], mid] = 2;
			championsrole2[champdict["cho'gath"], sup] = 1;
			championsrole2[champdict["cho'gath"], jg] = 1;
			championsrole2[champdict["nasus"], top] = 2;
			championsrole2[champdict["nasus"], mid] = 1;
			championsrole2[champdict["rek'sai"], top] = 1;
			championsrole2[champdict["rek'sai"], jg] = 2;
			championsrole2[champdict["vi"], jg] = 2;
			championsrole2[champdict["kled"], top] = 2;
			championsrole2[champdict["kled"], mid] = 1;
			championsrole2[champdict["taliyah"], mid] = 1;
			championsrole2[champdict["taliyah"], adc] = 2;
			championsrole2[champdict["taliyah"], sup] = 1;
			championsrole2[champdict["taliyah"], jg] = 1;
			championsrole2[champdict["amumu"], sup] = 1;
			championsrole2[champdict["amumu"], jg] = 2;
			championsrole2[champdict["kayle"], top] = 2;
			championsrole2[champdict["kayle"], mid] = 1;
			championsrole2[champdict["garen"], top] = 2;
			championsrole2[champdict["garen"], mid] = 1;
			championsrole2[champdict["warwick"], jg] = 2;
			championsrole2[champdict["tryndamere"], top] = 2;
			championsrole2[champdict["tryndamere"], mid] = 1;
			championsrole2[champdict["tryndamere"], jg] = 1;
			championsrole2[champdict["azir"], top] = 1;
			championsrole2[champdict["azir"], adc] = 1;
			championsrole2[champdict["azir"], mid] = 2;
			championsrole2[champdict["ziggs"], top] = 1;
			championsrole2[champdict["ziggs"], mid] = 2;
			championsrole2[champdict["ziggs"], sup] = 1;
			championsrole2[champdict["ziggs"], adc] = 1;
			championsrole2[champdict["wukong"], top] = 1;
			championsrole2[champdict["wukong"], mid] = 1;
			championsrole2[champdict["wukong"], jg] = 2;
			championsrole2[champdict["lissandra"], top] = 1;
			championsrole2[champdict["lissandra"], mid] = 2;
			championsrole2[champdict["lissandra"], sup] = 1;
			championsrole2[champdict["anivia"], mid] = 2;
			championsrole2[champdict["olaf"], top] = 1;
			championsrole2[champdict["olaf"], jg] = 2;
			championsrole2[champdict["braum"], sup] = 2;
			championsrole2[champdict["galio"], mid] = 2;
			championsrole2[champdict["galio"], sup] = 1;
			championsrole2[champdict["poppy"], top] = 2;
			championsrole2[champdict["poppy"], sup] = 1;
			championsrole2[champdict["poppy"], jg] = 1;
			championsrole2[champdict["xinzhao"], top] = 1;
			championsrole2[champdict["xinzhao"], mid] = 1;
			championsrole2[champdict["xinzhao"], jg] = 2;
			championsrole2[champdict["zac"], top] = 1;
			championsrole2[champdict["zac"], sup] = 1;
			championsrole2[champdict["zac"], jg] = 2;
			championsrole2[champdict["rumble"], top] = 1;
			championsrole2[champdict["rumble"], mid] = 2;
			championsrole2[champdict["sion"], top] = 2;
			championsrole2[champdict["sion"], mid] = 1;
			championsrole2[champdict["sion"], sup] = 1;
			championsrole2[champdict["sion"], jg] = 1;
			championsrole2[champdict["illaoi"], top] = 2;
			championsrole2[champdict["illaoi"], mid] = 1;
			championsrole2[champdict["khazix"], jg] = 2;
			championsrole2[champdict["masteryi"], top] = 1;
			championsrole2[champdict["masteryi"], jg] = 2;

			for (int h = 0; h < 5; h++)
			{
				int i = 0;
				for (int j = 10000; j >= 0; j--)
				{
					if (championsrole2[j, h] > 0 && i < 3)
					{
						champions.Add(champdict.Where(a => a.Value == j).FirstOrDefault().Key);
						i++;
					};
				};
				Console.WriteLine();
				Console.WriteLine(roles[h]);
				switch (h)
				{
					case 0:
						Console.WriteLine(champions[0]);
						Console.WriteLine(champions[1]);
						Console.WriteLine(champions[2]);
						break;
					case 1:
						Console.WriteLine(champions[3]);
						Console.WriteLine(champions[4]);
						Console.WriteLine(champions[5]);
						break;
					case 2:
						Console.WriteLine(champions[6]);
						Console.WriteLine(champions[7]);
						Console.WriteLine(champions[8]);
						break;
					case 3:
						Console.WriteLine(champions[9]);
						Console.WriteLine(champions[10]);
						Console.WriteLine(champions[11]);
						break;
					case 4:
						Console.WriteLine(champions[12]);
						Console.WriteLine(champions[13]);
						Console.WriteLine(champions[14]);
						break;
				}
			}
		}
	}
}


