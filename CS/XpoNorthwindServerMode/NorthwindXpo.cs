using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;

namespace NorthwindXpo {

    public class Employee : XPObject {
        public Employee(Session session) : base(session) { }

        string fLastName;
        public string LastName {
            get { return fLastName; }
            set { SetPropertyValue("LastName", ref fLastName, value); }
        }
        string fFirstName;
        public string FirstName {
            get { return fFirstName; }
            set { SetPropertyValue("FirstName", ref fFirstName, value); }
        }
        string fTitle;
        public string Title {
            get { return fTitle; }
            set { SetPropertyValue("Title", ref fTitle, value); }
        }
        DateTime fBirthDate;
        public DateTime BirthDate {
            get { return fBirthDate; }
            set { SetPropertyValue("BirthDate", ref fBirthDate, value); }
        }
        DateTime fHireDate;
        public DateTime HireDate {
            get { return fHireDate; }
            set { SetPropertyValue("HireDate", ref fHireDate, value); }
        }
        string fAddress;
        public string Address {
            get { return fAddress; }
            set { SetPropertyValue("Address", ref fAddress, value); }
        }
        string fCity;
        public string City {
            get { return fCity; }
            set { SetPropertyValue("City", ref fCity, value); }
        }
        string fPostalCode;
        public string PostalCode {
            get { return fPostalCode; }
            set { SetPropertyValue("PostalCode", ref fPostalCode, value); }
        }
        string fCountry;
        public string Country {
            get { return fCountry; }
            set { SetPropertyValue("Country", ref fCountry, value); }
        }
        string fHomePhone;
        public string HomePhone {
            get { return fHomePhone; }
            set { SetPropertyValue("HomePhone", ref fHomePhone, value); }
        }
        string fExtension;
        public string Extension {
            get { return fExtension; }
            set { SetPropertyValue("Extension", ref fExtension, value); }
        }
        string fNotes;
        [Size(SizeAttribute.Unlimited)]
        public string Notes {
            get { return fNotes; }
            set { SetPropertyValue("Notes", ref fNotes, value); }
        }
        Employee fReportsTo;
        [Association("Employee-Subordinates")]
        public Employee ReportsTo {
            get { return fReportsTo; }
            set { SetPropertyValue<Employee>("ReportsTo", ref fReportsTo, value); }
        }

        [Association("Employee-Orders")]
        public XPCollection<Order> Orders {
            get {
                return GetCollection<Order>("Orders");
            }
        }

        [Association("Employee-Subordinates")]
        public XPCollection<Employee> Subordinates {
            get {
                return GetCollection<Employee>("Subordinates");
            }
        }
    }

    public class Order : XPObject {
        public Order(Session session) : base(session) { }

        Customer fCustomer;
        [Association("Customer-Orders")]
        public Customer Customer {
            get { return fCustomer; }
            set { SetPropertyValue("Customer", ref fCustomer, value); }
        }
        Employee fEmployee;
        [Association("Employee-Orders")]
        public Employee Employee {
            get { return fEmployee; }
            set { SetPropertyValue<Employee>("Employee", ref fEmployee, value); }
        }
        DateTime fOrderDate;
        public DateTime OrderDate {
            get { return fOrderDate; }
            set { SetPropertyValue("OrderDate", ref fOrderDate, value); }
        }
        DateTime fShippedDate;
        public DateTime ShippedDate {
            get { return fShippedDate; }
            set { SetPropertyValue("ShippedDate", ref fShippedDate, value); }
        }
        decimal fFreight;
        public decimal Freight {
            get { return fFreight; }
            set { SetPropertyValue("Freight", ref fFreight, value); }
        }
        string fShipName;
        public string ShipName {
            get { return fShipName; }
            set { SetPropertyValue("ShipName", ref fShipName, value); }
        }
        string fShipAddress;
        public string ShipAddress {
            get { return fShipAddress; }
            set { SetPropertyValue("ShipAddress", ref fShipAddress, value); }
        }
        string fShipCity;
        public string ShipCity {
            get { return fShipCity; }
            set { SetPropertyValue("ShipCity", ref fShipCity, value); }
        }
        string fShipRegion;
        public string ShipRegion {
            get { return fShipRegion; }
            set { SetPropertyValue("ShipRegion", ref fShipRegion, value); }
        }
        string fShipPostalCode;
        public string ShipPostalCode {
            get { return fShipPostalCode; }
            set { SetPropertyValue("ShipPostalCode", ref fShipPostalCode, value); }
        }
        string fShipCountry;
        public string ShipCountry {
            get { return fShipCountry; }
            set { SetPropertyValue("ShipCountry", ref fShipCountry, value); }
        }
    }

    public class Customer : XPObject {
        public Customer(Session session) : base(session) { }

        string fCompanyName;
        public string CompanyName {
            get { return fCompanyName; }
            set { SetPropertyValue("CompanyName", ref fCompanyName, value); }
        }
        string fContactName;
        public string ContactName {
            get { return fContactName; }
            set { SetPropertyValue("ContactName", ref fContactName, value); }
        }
        string fContactTitle;
        public string ContactTitle {
            get { return fContactTitle; }
            set { SetPropertyValue("ContactTitle", ref fContactTitle, value); }
        }
        string fAddress;
        public string Address {
            get { return fAddress; }
            set { SetPropertyValue("Address", ref fAddress, value); }
        }
        string fCity;
        public string City {
            get { return fCity; }
            set { SetPropertyValue("City", ref fCity, value); }
        }
        string fRegion;
        public string Region {
            get { return fRegion; }
            set { SetPropertyValue("Region", ref fRegion, value); }
        }
        string fPostalCode;
        public string PostalCode {
            get { return fPostalCode; }
            set { SetPropertyValue("PostalCode", ref fPostalCode, value); }
        }
        string fCountry;
        public string Country {
            get { return fCountry; }
            set { SetPropertyValue("Country", ref fCountry, value); }
        }
        string fPhone;
        public string Phone {
            get { return fPhone; }
            set { SetPropertyValue("Phone", ref fPhone, value); }
        }

        [Association("Customer-Orders")]
        public XPCollection<Order> Orders {
            get {
                return GetCollection<Order>("Orders");
            }
        }
    }

    public class Category : XPObject {
        public Category(Session session) : base(session) { }

        string fCategoryName;
        public string CategoryName {
            get { return fCategoryName; }
            set { SetPropertyValue("CategoryName", ref fCategoryName, value); }
        }
        string fDescription;
        [Size(SizeAttribute.Unlimited)]
        public string Description {
            get { return fDescription; }
            set { SetPropertyValue("Description", ref fDescription, value); }
        }

        [Association("Category-Products")]
        public XPCollection<Product> Products {
            get {
                return GetCollection<Product>("Products");
            }
        }
    }

    public class Product : XPObject {
        public Product(Session session) : base(session) { }

        string fProductName;
        public string ProductName {
            get { return fProductName; }
            set { SetPropertyValue("ProductName", ref fProductName, value); }
        }
        Category fCategory;
        [Association("Category-Products")]
        public Category Category {
            get { return fCategory; }
            set { SetPropertyValue<Category>("Category", ref fCategory, value); }
        }
        string fQuantityPerUnit;
        public string QuantityPerUnit {
            get { return fQuantityPerUnit; }
            set { SetPropertyValue("QuantityPerUnit", ref fQuantityPerUnit, value); }
        }
        decimal fUnitPrice;
        public decimal UnitPrice {
            get { return fUnitPrice; }
            set { SetPropertyValue("UnitPrice", ref fUnitPrice, value); }
        }
        bool fDiscontinued;
        public bool Discontinued {
            get { return fDiscontinued; }
            set { SetPropertyValue("Discontinued", ref fDiscontinued, value); }
        }
    }
}
