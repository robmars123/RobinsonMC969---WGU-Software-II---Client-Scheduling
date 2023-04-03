using Client_Scheduler.Models;
using Client_Scheduler.ViewModels;
using DbDataReaderMapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Client_Scheduler
{
    public class Service
    {
        //Note: ContextDB is using App.Config ConnectionString. String below is used on MySqlCommand embedded query. 
        public static string conString = "server=localhost;database=client_schedule;user id=sqlUser;password=passw0rd!";
        private static User loggedInUser = new User();

        //Get List of Appontments
        public static async Task<List<Appointment>> GetAppointments(User user)
        {
            using (var contextDB = new ClientDBContext())
            {
                //Lambda expression is used, get list of appointments filtered by logged in user's userId. To see only records with this userId is pulled.
                var appointments = contextDB.Appointments.Where(appt => appt.userId == user.userId).ToList();
                return appointments;
            }
        }
        //Get User information
        public static User GetUser(string userName, string password)
        {
            using(var contextDB = new ClientDBContext())
            {
                //Lambda expression is used, searches from the list of users in the Users Table in the database filtered by parameters Username and Password.
                //Returns single object or record.
                return contextDB.Users.Where(user => user.userName.Trim() == userName && user.password.Trim() == password).FirstOrDefault();
            }
        }

        public static async Task<List<Customer>> GetCustomers()
        {
            using (var contextDB = new ClientDBContext())
            {
                //grabs list of customers filterless. 
                return await contextDB.Customers.ToListAsync();
            }
        }

        //Create Customer
        public static void AddCustomer(Customer customer)
        {
            try
            {
                int countryId = Save(customer, "country", 0);
                int cityId = Save(customer, "city", countryId);
                int addressId = Save(customer, "address", cityId);
                int customerId = Save(customer, "customer", addressId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static public int Save(Customer model, string tableName, int recordId)
        {
            string query = string.Empty;
            int id = 0;
            //country
            if (tableName == "country")
            {
                string countryIdQuery = "select countryId from " + tableName + " c order by 1 desc LIMIT 1";
                id = GetId(countryIdQuery);
                query = $"INSERT INTO " + tableName
                + $" VALUES ('{id}', '{model.address.city.country.country}', '{model.createDate.ToString("yyyy-MM-dd H:mm:ss")}','{model.createdBy}', '{model.lastUpdate.ToString("yyyy-MM-dd H:mm:ss")}', '{model.lastUpdateBy}')";
            }
            //city
            else if (tableName == "city")
            {
                string cityIdQuery = "select cityId from " + tableName + " c order by 1 desc LIMIT 1";
                id = GetId(cityIdQuery);
                query = $"INSERT INTO " + tableName
                 + $" VALUES ('{id}', '{model.address.city.city}', '{recordId}', '{model.createDate.ToString("yyyy-MM-dd H:mm:ss")}', '{model.createdBy}', '{model.lastUpdate.ToString("yyyy-MM-dd H:mm:ss")}', '{model.lastUpdateBy}')";
            }
            //address
            else if (tableName == "address")
            {
                string addressIdQuery = "select addressId from " + tableName + " c order by 1 desc LIMIT 1";
                id = GetId(addressIdQuery);
                query = $"INSERT INTO " + tableName
                 + $" VALUES ('{id}', '{model.address.address}', '{model.address.address2}', '{recordId}', '{model.address.postalCode}','{model.address.phone}','{model.address.createDate.ToString("yyyy-MM-dd H:mm:ss")}','{model.address.createdBy}','{model.address.lastUpdate.ToString("yyyy-MM-dd H:mm:ss")}', '{model.address.lastUpdateBy}')";
            }
            //customer
            else if (tableName == "customer")
            {
                string customerIdQuery = "select addressId from " + tableName + " c order by 1 desc LIMIT 1";
                id = GetId(customerIdQuery);
                int isActive = model.active ? 1 : 0;
                query = $"INSERT INTO " + tableName + " (customerId, customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy)"
                 + $" VALUES ('{id}', '{model.customerName}', '{recordId}', '{isActive}','{model.createDate.ToString("yyyy-MM-dd H:mm:ss")}','{model.createdBy}','{model.lastUpdate.ToString("yyyy-MM-dd H:mm:ss")}', '{model.lastUpdateBy}')";
            }

            //set connection to MySQL
            MySqlConnection c = new MySqlConnection(conString);
            c.Open();
            MySqlCommand cust = new MySqlCommand(query, c);
            MySqlDataReader reader = cust.ExecuteReader();
            while (reader.Read())
            {
                id = Convert.ToInt32(reader[0]) + 1;
            }
            reader.Close();
            c.Close();
            return id;
        }

        public static int GetId(string query)
        {
            //set connection to MySQL
            MySqlConnection c = new MySqlConnection(conString);
            c.Open();
            MySqlCommand cust = new MySqlCommand(query, c);
            MySqlDataReader reader = cust.ExecuteReader();
            int id = 0;

            while (reader.Read())
            {
                id = Convert.ToInt32(reader[0]) + 1;
            }
            reader.Close();
            c.Close();
            return id;
        }

        public static Address GetAddressQuery(int addressId)
        {
            using (var contextDB = new ClientDBContext())
            {
                //Lambda expression is used, grabs single address record filtered by the passed parameter addressId. FirstOrDefault grabs a single record.
                return contextDB.Addresses.Where(a => a.addressId == addressId).FirstOrDefault();
            }
        }

        public static City GetCity(int cityId)
        {
            using (var contextDB = new ClientDBContext())
            {
                //Lambda expression is used, grabs the city directly from City table where record's
                //cityId is equal to the cityId from the passed parameter 'cityId'. Single record only.
                return contextDB.Cities.Where(city => city.cityId == cityId).FirstOrDefault();
            }
        }

        public static Country GetCountry(int countryId)
        {
            using (var contextDB = new ClientDBContext())
            {
                //Lambda expression is used, grabs the Country directly from the
                //database's country table where records is equal to countryId passed from the parameter.
                //single record only.
                return contextDB.Countries.Where(country => country.countryId == countryId).FirstOrDefault();
            }
        }
        //UpdateCustomer using EF6 Code First approach
        public static void UpdateCustomer(Customer customer)
        {
            try
            {
                using (var contextDB = new ClientDBContext())
                {
                    contextDB.Entry(customer.address.city.country).State = EntityState.Modified;
                    contextDB.Entry(customer.address.city).State = EntityState.Modified;
                    contextDB.Entry(customer.address).State = EntityState.Modified;
                    contextDB.Entry(customer).State = EntityState.Modified;
                    contextDB.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void DeleteCustomer(Customer customer)
        {
            try
            {
                //remove child customer
                using (var contextDB = new ClientDBContext())
                {
                    //Lambda expression is used, grab list of appointments using passed parameter customer object's customerId. 
                    var appointments = contextDB.Appointments.Where(a => a.customerId == customer.customerId).ToList();

                    //remove any existing appointments
                    if (appointments.Any())
                    {
                        foreach (var appointment in appointments)
                        {
                            contextDB.Appointments.Remove(appointment);
                        }
                        contextDB.SaveChanges();
                    }
                    var deleteCustomerRecord = contextDB.Customers.Find(customer.customerId);
                    contextDB.Customers.Remove(deleteCustomerRecord);

                    contextDB.SaveChanges();
                }
                //remove child addresses
                using (var contextDB = new ClientDBContext())
                {
                    //Lambda expression is used, grabs list of addresses filter by cityId from current customer object. Customer can have many addresses in 1 city.
                    var addressList = contextDB.Addresses.Where(a => a.cityId == customer.address.cityId).ToList();

                    //remove any existing addresses in the city for this customer
                    if (addressList.Any())
                    {
                        foreach (var address in addressList)
                        {
                            contextDB.Addresses.Remove(address);
                        }
                        contextDB.SaveChanges();
                    }
                }
                //remove child city
                using (var contextDB = new ClientDBContext())
                {
                    //Lambda expression is used, find all existing list of cities in which country this customer lives. 1 Country can have many cities.
                    var cityList = contextDB.Cities.Where(c => c.countryId == customer.address.city.countryId).ToList();

                    //remove any existing cities for this country where the customer lives.
                    if (cityList.Any())
                    {
                        foreach (var city in cityList)
                        {
                            contextDB.Cities.Remove(city);
                        }
                        contextDB.SaveChanges();
                    }
                }
                //remove child country
                using (var contextDB = new ClientDBContext())
                {
                    var deleteCountryRecord = contextDB.Countries.Find(customer.address.city.country.countryId);
                    contextDB.Countries.Remove(deleteCountryRecord);
                    contextDB.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<string> GetCustomerIdAndNameList()
        {
            List<string> customerIds = new List<string>();
            using (var contextDB = new ClientDBContext())
            {
                //Lambda expression is used, grabs list of customers and select only CustomerID and CustomerName and format them appropriately. Example, ID: 50 - Robinson Majorenos
                customerIds = contextDB.Customers.Select(cust => "ID: " + cust.customerId + " - " + cust.customerName).ToList();
            }
            return customerIds;
        }

        public static List<string> GetUsersList()
        {
            List<string> userList = new List<string>();
            using (var contextDB = new ClientDBContext())
            {
                //Lambda expression is used, add list of string with ID and Username displayed. Example, ID: userid - test string format for combobox.
                userList = contextDB.Users.Select(user => "ID: " + user.userId + " - " + user.userName).ToList();
            }
            return userList;
        }

        public static void AddAppointment(Appointment appointment)
        {
            using (var contextDB = new ClientDBContext())
            {
                contextDB.Appointments.Add(appointment);
                contextDB.SaveChanges();
            }
        }

        public static void UpdateAppointment(Appointment appointment)
        {
            using (var contextDB = new ClientDBContext())
            {
                contextDB.Entry(appointment).State = EntityState.Modified;
                contextDB.SaveChanges();
            }
        }
        public static bool HasConflictSchedule(DateTime startTime, DateTime endTime)
        {
            foreach (var existingTimeSlot in GetAppointments(loggedInUser).Result)
            {
                if (startTime <= DateTime.Parse(existingTimeSlot.end.ToString()) && DateTime.Parse(existingTimeSlot.start.ToString()) <= endTime)
                    return true;
            }
            return false;
        }

        public static bool IsOutsideOfBusinessHours(DateTime startTime, DateTime endTime)
        {
            DateTime startOfOfficeHours = DateTime.Today.AddHours(8); // 8am
            DateTime endOfOfficeHours = DateTime.Today.AddHours(17); // 5pm
            if (startTime.TimeOfDay > startOfOfficeHours.TimeOfDay && startTime.TimeOfDay < endOfOfficeHours.TimeOfDay &&
                endTime.TimeOfDay > startOfOfficeHours.TimeOfDay && endTime.TimeOfDay < endOfOfficeHours.TimeOfDay)
                return false;

            return true;
        }

        public static void DeleteAppointment(Appointment appointment)
        {
            using (var contextDB = new ClientDBContext())
            {
                //Lambda expression is used, grab the object to be deleted using appointmentId from any of the appointments and grab the first one of the record result.
                var toRemove = contextDB.Appointments.Where(app => app.appointmentId == appointment.appointmentId).FirstOrDefault();
                contextDB.Appointments.Remove(toRemove);
                contextDB.SaveChanges();
            }
        }

        public static User GetUserDetails(int id)
        {
            using (var contextDB = new ClientDBContext())
            {
                //Lambda expression is used, grab user equals to the userId of the passed paramater value and grab the first or default. single value only.
                return contextDB.Users.Where(user => user.userId == id).FirstOrDefault();
            }

        }

        //Main form of displaying Appointments
        public static List<AppointmentsCalendar> AppointmentsCalendarList(List<Appointment> list)
        {
            List<AppointmentsCalendar> apptList = new List<AppointmentsCalendar>();
            foreach (var appt in list)
            {
                apptList.Add(new AppointmentsCalendar
                {
                    appointment = appt, //used for update/delete
                    AppointmentId = appt.appointmentId,
                    User = appt.GetUserName(),
                    CustomerId = appt.customerId,
                    CustomerName = appt.GetCustomerName(),
                    Type = appt.type,
                    StartDate = Service.ConvertToTimeZone(appt.start.ToString()),
                    EndDate = Service.ConvertToTimeZone(appt.end.ToString()),
                    UserId = appt.userId
                });
            }

            return apptList;
        }

        public static string ConvertToTimeZone(string dateTime)
        {
            DateTime utcDateTime = DateTime.Parse(dateTime.ToString());
            DateTime localDateTime = utcDateTime.ToLocalTime();

            return localDateTime.ToString("MM/dd/yyyy hh:mm tt");
        }

        //Get Types By Month Report
        public static List<TypesByMonthReports> GetTypesByMonthReport(User loggedInUser)
        {
            List<TypesByMonthReports> byMonthReports = new List<TypesByMonthReports>();
            using (var contextDB = new ClientDBContext())
            {
                //Lambda expression is used, grabs list of appointments filtered by logged in user and group the list by TYPE, and MONTH and count number of records.
                //lambda is used here to compare every record equals to the loggedinuser.UserId passed from the parameter.
                var resultList = contextDB.Appointments.Where(app=>app.userId == loggedInUser.userId).GroupBy(appt => new
                {
                    appt.type,
                    appt.start.Month
                }).ToList();

                foreach (var record in resultList)
                {
                    byMonthReports.Add(new TypesByMonthReports
                    {
                        Type = record.Key.type.ToString(),
                        Month = record.FirstOrDefault().start.ToString("MMMM"),
                        Count = record.ToList().Count()
                    });
                }
            }
            return byMonthReports;
        }
    }
}