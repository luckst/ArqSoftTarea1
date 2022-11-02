using Newtonsoft.Json;
using System.Net;
using System.Text;
using System.Web;
using System;

namespace ArqSoftware.CRUD.Web.Utilidades
{
    public class UtilidadHttp<T>
    {
        public static T EnviarPeticionREST(string url, HttpMethod httpMethod, Dictionary<string, string> queryString = null, object body = null, string usuario = null, string clave = null)
        {
            try
            {
                T entity = default(T);
                string apiPath = "http://localhost:5045/api/";
                using (var client = new HttpClient())
                {
                    var httpContent = body is null ? null : new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");

                    if (queryString != null && queryString.Count > 0)
                    {
                        var builder = new UriBuilder($"{apiPath}{url}");
                        var query = HttpUtility.ParseQueryString(builder.Query);

                        foreach (var item in queryString)
                        {
                            query[item.Key] = item.Value;
                        }

                        builder.Query = query.ToString();

                        url = builder.ToString();
                    }

                    HttpRequestMessage request = new HttpRequestMessage
                    {
                        Method = httpMethod,
                        RequestUri = new Uri($"{apiPath}{url}"),
                        Content = httpContent
                    };

                    //var result = await client.GetAsync(url);

                    var result = client.SendAsync(request).Result;

                    if (result.StatusCode != HttpStatusCode.OK)
                    {
                        throw new Exception(result?.Content.ReadAsStringAsync().Result);
                    }

                    var response = result.Content.ReadAsStringAsync().Result;
                    entity = JsonConvert.DeserializeObject<T>(response);

                    //}

                    return entity;
                }
            }
            catch (WebException ex)
            {
                var statusCode = ((HttpWebResponse)ex.Response).StatusCode;
                throw new Exception("An error occurred, status code: " + statusCode);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
