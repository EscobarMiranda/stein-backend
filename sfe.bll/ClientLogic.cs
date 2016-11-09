
using Newtonsoft.Json;
using sfe.bll.Exceptions;
using sfe.dal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sfe.bll
{
    public class ClientLogic
    {
        private static DataClassesDataContext db = Database.Instance;
        private static JsonSerializerSettings settings = new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            Formatting = Formatting.Indented
        };
        public static List<Client> Read()
        {
            try
            {
                string json = JsonConvert.SerializeObject(db.Clients.ToList(), settings);
                List<Client> listClientsTmp = JsonConvert.DeserializeObject<List<Client>>(json);
                List<Client> listClients = new List<Client>();
                listClientsTmp.ForEach(clients => {
                    clients.Visits = null;
                    clients.Potential = null;
                    clients.Answers = null;
                    clients.Adoption = null;
                    clients.User = null;
                    listClients.Add(clients);
                });
                return listClients;
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("sfe", e.StackTrace.ToString(), EventLogEntryType.Error);
                throw new ClientListNotFoundException("Client list not found");
            }
        }

        public static List<Client> Read(int clientTypeId, int userId)
        {
            try
            {
                string json = JsonConvert.SerializeObject(db.Clients.Where(c => c.active == true && c.FK_clientType == clientTypeId && c.FK_user == userId).ToList(), settings);
                List<Client> listClientsTmp = JsonConvert.DeserializeObject<List<Client>>(json);
                List<Client> listClients = new List<Client>();
                listClientsTmp.ForEach(clients => {
                    clients.Visits = null;
                    clients.Potential = null;
                    clients.Answers = null;
                    clients.Adoption = null;
                    clients.User = null;
                    listClients.Add(clients);
                });
                return listClients;
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("sfe", e.StackTrace.ToString(), EventLogEntryType.Error);
                throw new ClientListNotFoundException("Client list not found");
            }
        }

        public static Client Read(int id)
        {
            try
            {
                string json = JsonConvert.SerializeObject(db.Clients.Where(c => c.idClient == id).ToList(), settings);
                List<Client> listClientsTmp = JsonConvert.DeserializeObject<List<Client>>(json);
                List<Client> listClients = new List<Client>();
                listClientsTmp.ForEach(clients => {
                    clients.Visits = null;
                    clients.Potential = null;
                    clients.Answers = null;
                    clients.Adoption = null;
                    clients.User = null;
                    listClients.Add(clients);
                });
                return listClients.First();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("sfe", e.StackTrace.ToString(), EventLogEntryType.Error);
                throw new ClientNotFoundException("Client not found");
            }
        }

        public static void Create(Client client)
        {
            try
            {
                db.Clients.InsertOnSubmit(client);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("sfe", e.StackTrace.ToString(), EventLogEntryType.Error);
                throw new PostClientException("Error creating client");
            }
        }

        public static void Delete(int id)
        {
            try
            {
                Client tmpClient = Read(id);
                tmpClient.active = false;
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("sfe", e.StackTrace.ToString(), EventLogEntryType.Error);
                throw new DeleteClientException("Error deleting client");
            }
        }

        public static void Update(Client client)
        {
            try
            {
                Client tmpClient = Read(client.idClient);
                tmpClient.name = client.name;
                tmpClient.lastName = client.lastName;
                tmpClient.speciality = client.speciality;
                tmpClient.FK_potential = client.FK_potential;
                tmpClient.FK_potential = client.FK_potential;
                tmpClient.country = client.country;
                tmpClient.province = client.province;
                tmpClient.address1 = client.address1;
                tmpClient.address2 = client.address2;
                tmpClient.zone = client.zone;
                tmpClient.latitude = client.latitude;
                tmpClient.longitude = client.longitude;
                tmpClient.email = client.email;
                tmpClient.phone1 = client.phone1;
                tmpClient.phone2 = client.phone2;
                tmpClient.maxNumVisits = client.maxNumVisits;
                tmpClient.FK_clientType = client.FK_clientType;
                tmpClient.FK_user = client.FK_user;
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("sfe", e.StackTrace.ToString(), EventLogEntryType.Error);
                throw new UpdateClientException("Error updating client");
            }
        }
    }
}
