using System;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class CPHInline
{
    public bool Execute()
    {
        using (HttpClient _client = new HttpClient())
        {
            var httpTimeout = TimeSpan.FromSeconds(3);
            _client.Timeout = httpTimeout;
			string jokeJSON = "Jesus walked on water. Chuck Norris swam on land";
			try
			{
				jokeJSON = _client.GetStringAsync("https://api.chucknorris.io/jokes/random").Result;
				var objects = JObject.Parse(jokeJSON);
				string joke = objects["value"].ToString();
				CPH.SendMessage(joke);
                var voice = args["voice"].ToString();

				System.Diagnostics.Process process = new System.Diagnostics.Process();
				System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
				startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
				startInfo.FileName = "C:\\Program Files\\Amazon\\AWSCLI\\bin\\aws.exe";

				string awsFile = "D:\\Streamer.bot\\data\\joker\\chuck.mp3";

				startInfo.Arguments = " polly synthesize-speech --output-format mp3 --text \"" + joke + "\" --voice-id " + voice + " " + awsFile;
				
				process.StartInfo = startInfo;
				process.Start();

			}
			catch (Exception e)
			{
				CPH.SendMessage(jokeJSON);
			}

            _client.Dispose();
        }

        return true;
    }
}