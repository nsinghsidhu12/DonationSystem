using System.Reflection.Metadata.Ecma335;
using ClassLibDb.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassLibDb.Data
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(GetContacts());
            modelBuilder.Entity<TransactionType>().HasData(GetTransactionTypes());
            modelBuilder.Entity<PaymentMethod>().HasData(GetPaymentMethods());
            modelBuilder.Entity<Donation>().HasData(GetDonations());
        }

        public static List<Contact> GetContacts()
        {
            var dateTimeUtc = DateTime.UtcNow;

            List<Contact> contacts = new() {
                new Contact {
                    AccountNo = 1,
                    FirstName = "Connor",
                    LastName = "McDavid",
                    Email = "connor@mcdavid.com",
                    Street = "10220 104 Ave NW",
                    City = "Edmonton",
                    PostalCode = "T5J 0H6",
                    Country = "Canada",
                    Created = dateTimeUtc,
                    Modified = dateTimeUtc,
                    CreatedBy = "System",
                    ModifiedBy = "System"
                },
                new Contact {
                    AccountNo = 2,
                    FirstName = "Thomas",
                    LastName = "Chabot",
                    Email = "thomas@chabot.com",
                    Street = "1000 Palladium Dr",
                    City = "Ottawa",
                    PostalCode = "K2V 1A5",
                    Country = "Canada",
                    Created = dateTimeUtc,
                    Modified = dateTimeUtc,
                    CreatedBy = "System",
                    ModifiedBy = "System"
                },
                new Contact {
                    AccountNo = 3,
                    FirstName = "Josh",
                    LastName = "Morrissey",
                    Email = "josh@morrisey.com",
                    Street = "300 Portage Ave",
                    City = "Winnipeg",
                    PostalCode = "R3C 5S4",
                    Country = "Canada",
                    Created = dateTimeUtc,
                    Modified = dateTimeUtc,
                    CreatedBy = "System",
                    ModifiedBy = "System"
                }
            };

            return contacts;
        }

        public static List<TransactionType> GetTransactionTypes()
        {
            var dateTimeUtc = DateTime.UtcNow;

            List<TransactionType> transactionTypes = new() {
                new TransactionType {
                    TransactionTypeId = 1,
                    Name = "General Donation",
                    Description = "Donations made without any special purpose",
                    Created = dateTimeUtc,
                    Modified = dateTimeUtc,
                    CreatedBy = "System",
                    ModifiedBy = "System"
                },
                new TransactionType {
                    TransactionTypeId = 2,
                    Name = "Food for homeless",
                    Description = "Donations made for homeless people",
                    Created = dateTimeUtc,
                    Modified = dateTimeUtc,
                    CreatedBy = "System",
                    ModifiedBy = "System"
                },
                new TransactionType {
                    TransactionTypeId = 3,
                    Name = "Repair of Gym",
                    Description = "Donations for the purpose of upgrading the gym",
                    Created = dateTimeUtc,
                    Modified = dateTimeUtc,
                    CreatedBy = "System",
                    ModifiedBy = "System"
                }
            };

            return transactionTypes;
        }

        public static List<PaymentMethod> GetPaymentMethods()
        {
            var dateTimeUtc = DateTime.UtcNow;

            List<PaymentMethod> paymentMethods = new() {
                new PaymentMethod {
                    PaymentMethodId = 1,
                    Name = "Direct Deposit",
                    Created = dateTimeUtc,
                    Modified = dateTimeUtc,
                    CreatedBy = "System",
                    ModifiedBy = "System"
                },
                new PaymentMethod {
                    PaymentMethodId = 2,
                    Name = "Paypal",
                    Created = dateTimeUtc,
                    Modified = dateTimeUtc,
                    CreatedBy = "System",
                    ModifiedBy = "System"
                },
                new PaymentMethod {
                    PaymentMethodId = 3,
                    Name = "Cheque",
                    Created = dateTimeUtc,
                    Modified = dateTimeUtc,
                    CreatedBy = "System",
                    ModifiedBy = "System"
                }
            };

            return paymentMethods;
        }

        public static List<Donation> GetDonations()
        {
            var dateTimeUtc = DateTime.UtcNow;

            List<Donation> donations = new() {
                new Donation {
                    TransId = 1,
                    Date = dateTimeUtc,
                    AccountNo = 1,
                    TransactionTypeId = 1,
                    Amount = 100,
                    PaymentMethodId = 1,
                    Notes = "Making a general donation using direct deposit",
                    Created = dateTimeUtc,
                    Modified = dateTimeUtc,
                    CreatedBy = "System",
                    ModifiedBy = "System"
                },
                new Donation {
                    TransId = 2,
                    Date = dateTimeUtc,
                    AccountNo = 2,
                    TransactionTypeId = 2,
                    Amount = 200,
                    PaymentMethodId = 2,
                    Notes = "Making a donation for food for homeless people using paypal",
                    Created = dateTimeUtc,
                    Modified = dateTimeUtc,
                    CreatedBy = "System",
                    ModifiedBy = "System"
                },
                new Donation {
                    TransId = 3,
                    Date = dateTimeUtc,
                    AccountNo = 3,
                    TransactionTypeId = 3,
                    Amount = 300,
                    PaymentMethodId = 3,
                    Notes = "Making a donation for upgrading the gym using a cheque",
                    Created = dateTimeUtc,
                    Modified = dateTimeUtc,
                    CreatedBy = "System",
                    ModifiedBy = "System"
                }
            };

            return donations;
        }
    }
}