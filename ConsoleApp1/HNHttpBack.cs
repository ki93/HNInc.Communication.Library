using System.Diagnostics;

namespace HNInc.Communication.Library
{
    public class HNHttpBack
    {
        public HNHttpBack()
        {
            Debug.WriteLine("Http Start");
        }
        //public void GetDeiviceHealthCheckRequest()
        //{
        //    string responseFromServer;
        //    // Create a request for the URL.
        //    WebRequest request = (HttpWebRequest)WebRequest.Create(
        //      "http://9.8.100.153:8082/spindleload/device-health-check?opcode=OP10-3");
        //    // If required by the server, set the credentials.
        //    //request.Credentials = CredentialCache.DefaultCredentials;

        //    // Get the response.
        //    // 409??
        //    WebResponse response = (HttpWebResponse)request.GetResponse();
        //    // Display the status.
        //    Console.WriteLine(((HttpWebResponse)response).StatusDescription);

        //    // Get the stream containing content returned by the server.
        //    // The using block ensures the stream is automatically closed.
        //    using (Stream dataStream = response.GetResponseStream())
        //    {
        //        // Open the stream using a StreamReader for easy access.
        //        StreamReader reader = new StreamReader(dataStream);
        //        // Read the content.
        //        responseFromServer = reader.ReadToEnd();
        //        // Display the content.
        //        Console.WriteLine("webrequest");
        //        Console.WriteLine(responseFromServer);
        //    }
        //    // Close the response.
        //    response.Close();
        //}
        //public void GetProductCountsRequest()
        //{
        //    string responseFromServer;
        //    // Create a request for the URL.

        //    string dateTime1 = new DateTime(2021, 10, 15).ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ssZ");
        //    string dateTime2 = new DateTime(2021, 11, 20).ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ssZ");
        //    WebRequest request = (HttpWebRequest)WebRequest.Create(
        //      "http://9.8.100.153:8082/spindleload/product-counts?startDate="+dateTime1+"&endDate="+dateTime2+"&opcode=OP10-3&classification=day");
        //    // If required by the server, set the credentials.
        //    //request.Credentials = CredentialCache.DefaultCredentials;

        //    // Get the response.
        //    // 409??
        //    WebResponse response = (HttpWebResponse)request.GetResponse();
        //    // Display the status.
        //    Console.WriteLine(((HttpWebResponse)response).StatusDescription);

        //    // Get the stream containing content returned by the server.
        //    // The using block ensures the stream is automatically closed.
        //    using (Stream dataStream = response.GetResponseStream())
        //    {
        //        // Open the stream using a StreamReader for easy access.
        //        StreamReader reader = new StreamReader(dataStream);
        //        // Read the content.
        //        responseFromServer = reader.ReadToEnd();
        //        // Display the content.
        //        Console.WriteLine("webrequest");
        //        Console.WriteLine(responseFromServer);
        //    }
        //    // Close the response.
        //    response.Close();
        //}
        //public void GetCycleTimeListRequest()
        //{
        //    string responseFromServer;
        //    // Create a request for the URL.
        //    WebRequest request = (HttpWebRequest)WebRequest.Create(
        //      "http://9.8.100.153:8082/spindleload/cycle-time-list");
        //    // If required by the server, set the credentials.
        //    //request.Credentials = CredentialCache.DefaultCredentials;

        //    // Get the response.
        //    // 409??
        //    WebResponse response = (HttpWebResponse)request.GetResponse();
        //    // Display the status.
        //    Console.WriteLine(((HttpWebResponse)response).StatusDescription);

        //    // Get the stream containing content returned by the server.
        //    // The using block ensures the stream is automatically closed.
        //    using (Stream dataStream = response.GetResponseStream())
        //    {
        //        // Open the stream using a StreamReader for easy access.
        //        StreamReader reader = new StreamReader(dataStream);
        //        // Read the content.
        //        responseFromServer = reader.ReadToEnd();
        //        // Display the content.
        //        Console.WriteLine("webrequest");
        //        Console.WriteLine(responseFromServer);
        //    }
        //    // Close the response.
        //    response.Close();
        //}
        //public void WebRequestPostRequest()
        //{
        //    User user = new User();
        //    // Create a request for the URL.
        //    WebRequest request = WebRequest.Create(
        //      "http://9.8.100.153:8082/main/post-test");
        //    request.ContentType = "application/json";
        //    request.Method = "POST";
        //    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
        //    {
        //        String data = JsonConvert.SerializeObject(user);
        //        streamWriter.Write(data);
        //        streamWriter.Flush();
        //        streamWriter.Close();
        //    }
        //    // Get the response.
        //    WebResponse response = request.GetResponse();
        //    // Display the status.
        //    Debug.WriteLine(((HttpWebResponse)response).StatusDescription);
        //    using (var streamReader = new StreamReader(response.GetResponseStream()))
        //    {
        //        var result = streamReader.ReadToEnd();
        //        Debug.WriteLine(result.GetType());
        //        Debug.WriteLine(result);
        //    }
        //    // Close the response.
        //    response.Close();
        //}
 
        //public void WebClientGetDeiviceHealthCheckRequest()
        //{
        //    // 간단한 방식 WebClient
        //    var response = new WebClient().DownloadStringTaskAsync("http://9.8.100.153:8082/spindleload/device-health-check?opcode=OP10-3");
        //    Console.WriteLine("WebClient device-health-check");
        //    Console.WriteLine(response.Result);
        //}
        ////public void WebClientGetCustomHistoryRequest()
        ////{
        ////    // 간단한 방식 WebClient
        ////    var response = new WebClient().DownloadString("http://9.8.100.153:8082/spindleload/custom-history?startdate=2021-11-18&enddate=2021-11-21");
        ////    Console.WriteLine("WebClient custom-history");
        ////    Console.WriteLine(response);
        ////}
        //public void WebClientProductCountsRequest()
        //{
        //    // 간단한 방식 WebClient
        //    var response = new WebClient().DownloadStringTaskAsync("http://9.8.100.153:8082/spindleload/product-counts?classification=days&start_date=2021-11-18&end_date=2021-11-21");
        //    Console.WriteLine("WebClient product-counts");
        //    Console.WriteLine(response.Result);
        //}
        //public void WebClientCycleTimeListRequest()
        //{
        //    // 간단한 방식 WebClient
        //    var response = new WebClient().DownloadString("http://9.8.100.153:8082/spindleload/cycle-time-list");
        //    Console.WriteLine("WebClient cycle-time-list");
        //    Console.WriteLine(response);
        //}
        //public void WebClientPostRequest()
        //{
        //    // 간단한 방식 WebClient
        //    User user = new User();
        //    String url = "http://9.8.100.153:8082/main/post-test";
        //    WebClient client = new WebClient();
        //    client.Headers[HttpRequestHeader.ContentType] = "application/json";
        //    String data = JsonConvert.SerializeObject(user);
        //    String reply = client.UploadString(url, data);
        //    Debug.WriteLine(reply.GetType());
        //    // Display the server's response.
        //    Debug.WriteLine(JsonConvert.DeserializeObject<object>(reply));

        //}
        //class User
        //{
        //    public int id { get; set; } = 1;
        //    public string title { get; set; } = "First Data";
        //    public string body { get; set; } = "First Body";
        //    public int userId { get; set; } = 222;
        //}
    }
}
