using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System;

namespace ClassLibrary
{
    public class API_Testingcs
    {
        [Test]
        public void TestPost()
        {
            string data = "{\r\n  \"firstName\": \"lavanya123\",\r\n  \"lastName\": \"v1223\",\r\n  \"trusted\": false\r\n}";
            Post(data);
        }

        //[Test]
        //public void TestPut()
        //{

        //    string putdata = "{\r\n  \"firstName\": \"Bharath\",\r\n  \"lastName\": \"javvaji\",\r\n  \"trusted\": false\r\n}";
        //    Put(putdata, "nzQAkEUk");
        //}
        //[Test]
        //public void TestDelete()
        //{


        //     Delete("nzQAkEUk");
        //}


        //[Test]
        //public void Temp()
        //{
        //   dynamic temp = JsonConvert.DeserializeObject("{'id':'nzQAkEUk', 'firstName': 'test',  'lastName': 'Testing'}");

        //    string id = temp.id;
        //    string firstname = temp.firstName;
        //    string lastName = temp.lastName;


        //}

        [Test]
       public void jsontest()
        {
            LandLords req = new LandLords("lavanya123", "v1233", true);
            //req.firstName = "lavanya";
            //req.lastName = "v";
            //req.trusted = true;
            String json = JsonConvert.SerializeObject(req);
            IRestResponse response = Post(json);
            //LandLords res = JsonConvert.DeserializeObject<LandLords>(response.Content);

            //Assert.AreEqual(req.trusted, res.trusted);
            //Assert.AreEqual(req.lastName, res.lastName);
            //Assert.AreEqual(req.firstName, res.firstName);

            //Delete(res.id);

        }
        
        public IRestResponse GetAll()
        {

            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);

            request.AddHeader("Accept", "application/json");

            IRestResponse response = client.Execute(request);
            return response;

        }

        public IRestResponse GetById(string id)
        {

            var client = new RestClient(url + "\\" + id);
            var request = new RestRequest(Method.GET);

            request.AddHeader("Accept", "application/json");

            IRestResponse response = client.Execute(request);
            return response;

        }

        //{\r\n  \"firstName\": \"test\",\r\n  \"lastName\": \"test\",\r\n  \"trusted\": false\r\n}

        string url = "http://localhost:8080/landlords";

        public IRestResponse Post(String postData)
        {

            var client = new RestClient(url);
            var request = new RestRequest(Method.POST);

            request.AddHeader("content-type", "application/json");

            request.AddParameter("application/json", postData, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);
            return response;
        }




        public IRestResponse Put(String putData, string id)
        {
            var client = new RestClient(url + "\\" + id);
            var request = new RestRequest(Method.PUT);

            request.AddHeader("content-type", "application/json");

            request.AddParameter("application/json", putData, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);
            return response;
        }
        public IRestResponse Delete(string id)
        {
            var client = new RestClient(url + "\\" + id);
            var request = new RestRequest(Method.DELETE);

            //request.AddHeader("content-type", "application/json");

            //request.AddParameter("application/json", putData, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);
            return response;
        }

       
    }
}
