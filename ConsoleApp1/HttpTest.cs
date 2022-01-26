using HNInc.Communication.Library;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp1
{
    class HttpTest
    {
        static void Main(string[] args)
        {
            HNHttp hNHttp = new HNHttp("http://9.8.100.153:8082/","Server=9.8.100.151;Port=3306;", "Uid=root;Pwd=!234567890;");
            //테스트 완료
            //1
            //Console.WriteLine(HNHttp.GetRealTimeCountRequest(HttpOPCode.OP10_3).ToString());
            //2
            //Console.WriteLine(HNHttp.GetCycleTimeAverageRequest(1).ToString());
            //3
            //Console.WriteLine(HNHttp.GetDeiviceHealthCheckRequest(HttpOPCode.OP10_3).ToString());
            //4
            //List<HttpProductCounts> productCounts = HNHttp.GetProductCountsRequest(new DateTime(2021, 11, 11), new DateTime(2021, 12, 3), HttpOPCode.OP10_3, HttpClassification.day);
            //Console.WriteLine(productCounts.Count);
            //Console.WriteLine(productCounts[0].ToString());
            ////5
            //List<HttpSpindleLoad> spindleLoads = HNHttp.GetSpindleLoadRequest(new DateTime(2021, 11, 29), new DateTime(2021, 11, 30), HttpOPCode.OP10_3, "10s");
            //Console.WriteLine(spindleLoads[spindleLoads.Count - 1].ToString());
            ////6 
            //DateTime dateTime = new DateTime(2022, 01, 26, 11, 45, 17);
            //DateTime dateTime2 = new DateTime(2022, 01, 26, 11, 48, 34);
            //List <HttpCycleInformaiton> cycleInformaitons = hNHttp.GetCycleInformationList(HttpOPCode.OP10_3,dateTime,dateTime2);
            //Console.WriteLine(cycleInformaitons[0].ToString());
            ////테스트 중
            //7
            //List<HttpCycleTime> cycleTimes = HNHttp.GetCycleTimeListRequest(HttpOPCode.OP10_3, 2);
            //Console.WriteLine(cycleTimes[0].ToString());
            // 마리아DB 10.6 캐릭터 셋 오류 
            //8
            //HttpAuthentication authentication = HNHttp.CheckAuthentication("admin", "1234");
            //Console.WriteLine(authentication.ToString());
            //9 보내주는 format 수정 필요(시리얼 넘버 굳이 감쌀 필요가?)
            //List <HttpProductInformation> productInformations = hNHttp.GetProductInformationList(1);
            //foreach (var item in productInformations)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            //10 문의 필요 바이트 안들어옴
            //HttpQualityInformaiton qualityInformaiton = HNHttp.GetQualityInformaiton();
            //Console.WriteLine(qualityInformaiton._imageBytes.Length);
            //TimeSpan timeSpan = TimeSpan.FromMilliseconds(Double.Parse("200851.4"));
            //Debug.WriteLine($"{timeSpan.Minutes}, {timeSpan.Seconds}");
        }
    }
}
