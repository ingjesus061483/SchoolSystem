using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
    public abstract  class Utilities<T>
    {

        public static string Api {  get; set; }
        static string HeaderValue { get { return ConfigurationManager.AppSettings["HeaderValue"]; } }
        static HttpClient HttpClient
        {
            get
            {
                var apiBaseUrl = ConfigurationManager.AppSettings["base_url"];
                HttpClient client = new HttpClient
                {                    
                    Timeout =TimeSpan .FromSeconds(60),
                    BaseAddress = new Uri(apiBaseUrl),
                };
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(HeaderValue));
                return client;
            }
        }
        public static bool OpenDialog(string  filter, ref string  path)
        {
            OpenFileDialog OpenFile = new OpenFileDialog  { Filter = filter };
            bool b = OpenFile.ShowDialog() == DialogResult.OK;
            path = OpenFile.FileName ;
            return b;
        }
        public static byte[] GetBytes(string path)
        {
            
            FileStream fileStream = new FileStream  (path, FileMode.Open, FileAccess.Read);
            int.TryParse(fileStream.Length.ToString(), out int length);
            byte[] bytes = { };
            Array.Resize(ref bytes, length);
            fileStream.Read(bytes, 0, length);
            return bytes;
        }
        public static Image LoadImage(byte[] imagenbuffer)
        {
            try
            {
                MemoryStream MemoryStream; Image img;
                MemoryStream = new MemoryStream(imagenbuffer);
                img = Image.FromStream(MemoryStream);
                return img;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static byte[] LoadImage(PictureBox picture, string path)
        {
            try
            {               
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Load(path);
                return GetBytes(path);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void FillCombo(List<T> values,string []arr , ComboBox combo)
        {
            combo.DataSource = values;
            combo.DisplayMember = arr.GetValue(1).ToString();
            combo.ValueMember = arr.GetValue(0).ToString();
            combo.SelectedIndex = -1;
        }
        public static  async Task< List<T> >Get()
        {
            HttpClient client = HttpClient;            
            HttpResponseMessage response =  await client.GetAsync(Api);
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                return  JsonConvert.DeserializeObject<List<T>>(await response.Content.ReadAsStringAsync());                
            }      
            throw new Exception(JsonConvert.DeserializeObject<string>(await response.Content.ReadAsStringAsync()));
        }
        public static async Task<T> Get(int id)
        {
            string api = $"{Api}/{id}"; 
            HttpClient client = HttpClient;
            HttpResponseMessage response = await client.GetAsync(api);
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
            }
            throw new Exception(JsonConvert.DeserializeObject<string>(await response.Content.ReadAsStringAsync()));
        }

        static StringContent GetStringContent(T data)
        {
            var content = new StringContent(JsonConvert.SerializeObject(data)) ;
            content.Headers.ContentType = new MediaTypeHeaderValue(HeaderValue );
            return content;
        }
        public static  async  Task<string >  Post(T data)
        {
            HttpClient client = HttpClient;
            var content=GetStringContent(data);
            HttpResponseMessage resp =await  client.PostAsync(Api,content);
            //This method throws an exception if the HTTP response status is an error code.  
            //var xx = resp.EnsureSuccessStatusCode();            
            if (resp.IsSuccessStatusCode)
            {             
                return await resp.Content.ReadAsStringAsync();
            }
            throw new Exception(JsonConvert.DeserializeObject<string>(await resp.Content.ReadAsStringAsync()));            
        }
        public static async Task<string> Put(int id, T data)
        {
            string api = $"{Api}/{id}"; 
            HttpClient client = HttpClient;
            var content = GetStringContent(data);
            HttpResponseMessage resp =await  client.PutAsync(api, content);
            //This method throws an exception if the HTTP response status is an error code.  
            //var xx = resp.EnsureSuccessStatusCode();            
            if (resp.IsSuccessStatusCode)
            {               
                return await resp.Content.ReadAsStringAsync();
            }
            throw new Exception(JsonConvert.DeserializeObject<string>(await resp.Content.ReadAsStringAsync()));
        }
        public static  async Task<string>Delete(int id )
        {
            string api = $"{Api}/{id}";
            HttpClient client = HttpClient;            
            HttpResponseMessage resp =await  client.DeleteAsync(api );
            //This method throws an exception if the HTTP response status is an error code.  
            //var xx = resp.EnsureSuccessStatusCode();            
            if (resp.IsSuccessStatusCode)
            {               
                return await resp.Content.ReadAsStringAsync(); 
            }
            throw new Exception(JsonConvert.DeserializeObject<string>(await resp.Content.ReadAsStringAsync()));
        }
        public static void CloseForm(T message ,FormClosingEventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show(message .ToString () , "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            e.Cancel = false;
        }
        public static List<T> GetValues(DataGridView dataGridView)
        {
            T[] Columns = new T[dataGridView.Columns.Count];
            dataGridView.Columns.CopyTo(Columns, 0);
            return Columns.ToList().Where(x => !string.IsNullOrEmpty(x.GetType()
                                    .GetRuntimeProperties().FirstOrDefault(z => z.Name == "Name")
                                    .GetValue(x).ToString()))
                                    .ToList();
        }
        public static void FillCombo(List<T> values, ComboBox combo)
        {
            combo.Items.Clear();
            foreach (var item in values)
            {
                PropertyInfo propertyInfo = item.GetType().GetRuntimeProperties()
                                                          .FirstOrDefault(x => x.Name == "Name");
                combo.Items.Add(propertyInfo.GetValue(item).ToString());
            }
            combo.SelectedIndex = 0;
        }
        public static bool GetValue(T z, string field, string value)
        {
            return z.GetType().GetProperty(field).GetValue(z)
                              .ToString().Contains(value);
        }
    }
}
