using FluentTester.Validator;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FluentTester.Models
{
    [Validator(typeof(PersonValidator))]
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Surname { get; set; }
        public string Forename { get; set; }
        public int Age { get; set; }
    }
}