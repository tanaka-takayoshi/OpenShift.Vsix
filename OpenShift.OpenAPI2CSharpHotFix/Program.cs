using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;

namespace OpenShift.OpenAPI2CSharpHotFix
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var json = client.GetStringAsync("https://raw.githubusercontent.com/openshift/origin/master/api/swagger-spec/openshift-openapi-spec.json").GetAwaiter().GetResult();
            var jobj = JsonConvert.DeserializeObject(json) as JObject;
            //jobj.Dump();
            var produces = jobj.SelectTokens("$..produces");
            void RemoveAster(System.Collections.Generic.IEnumerable<JToken> tokens)
            {
                foreach (var token in tokens)
                {
                    var array = token as JArray;
                    var remove = array?.FirstOrDefault(s => s.Value<string>() == "*/*");
                    if (remove != null)
                    {
                        array.Remove(remove);
                        array.Add("application/json");
                    }
                }
            }
            RemoveAster(produces);
            var consumes = jobj.SelectTokens("$..consumes");
            RemoveAster(consumes);

            var parameters = jobj.SelectTokens("$..parameters");
            foreach (var token in parameters)
            {
                var array = token as JArray;
                if (array == null)
                    continue;
                foreach (var param in array.Children())
                {
                    var p = param as JObject;
                    var isUnique = p?.Value<bool>("uniqueItems");
                    var type = p?.Value<string>("type");
                    if (isUnique == true && (type == "string" || type == "boolean" || type == "integer"))
                    {
                        p.Remove("uniqueItems");
                    }
                }
            }
            //jobj.Dump();
            //deleteするとresponseがdeleteしたオブジェクト

            //Iok8sapicorev1ServicePortのTargetPortはintかstring
            //Iok8sapicorev1HTTPGetActionのPort

            File.WriteAllText(@"D:\Downloads\openshift-openapi-spec3.json", JsonConvert.SerializeObject(jobj));
        }
        
    }
}
