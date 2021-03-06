﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RetentionUnit.Models;

namespace RetentionUnit.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public  JsonResult FindClient(Client model)
        {
            model.BirthPlace = "МОСКВА";
            model.Passport = "12 13 123456";
            model.BirthDate = DateTime.Today.ToString("d");
            var model2 = new Client
            {
                FullName = model.FullName,
                Ibso = model.Ibso,
                BirthDate = DateTime.Today.AddDays(1).ToString("d"),
                BirthPlace = model.BirthPlace,
                Passport = "13 12 123456",
                Phone = "1234567890"
            };
            var model3 = new Client
            {
                FullName = model.FullName,
                Ibso = model.Ibso,
                BirthDate = DateTime.Today.AddDays(3).ToString("d"),
                BirthPlace = model.BirthPlace,
                Passport = "15 17 321456",
                Phone = "5244527890"
            };
            var model4 = new Client
            {
                FullName = model.FullName,
                Ibso = model.Ibso,
                BirthDate = DateTime.Today.AddDays(-2).ToString("d"),
                BirthPlace = model.BirthPlace,
                Passport = "25 47 321456",
                Phone = "5245437890"
            };
            ClientsCollection clients = new ClientsCollection(model);
            clients.Clients.Add(model);
            clients.Clients.Add(model3);
            clients.Clients.Add(model4);
            clients.Clients.Add(model3);
            clients.Clients.Add(model);
            clients.Clients.Add(model2);
            clients.Clients.Add(model);
            clients.Clients.Add(model);
            clients.Clients.Add(model2);
            clients.Clients.Add(model4);
            clients.Clients.Add(model3);
            clients.Clients.Add(model);
            clients.Clients.Add(model2);
            clients.Clients.Add(model);
            clients.Clients.Add(model);
            clients.Clients.Add(model3);
            clients.Clients.Add(model4);
            clients.Clients.Add(model2);
            clients.Clients.Add(model4);
            clients.Clients.Add(model3);
            clients.Clients.Add(model2);
            return Json(clients);
        }

        public IActionResult SelectedClient(int ibsoid)
        {
            var client = new Client
            {
                BirthDate = DateTime.Now.ToString("d"),
                BirthPlace = "МОСКВА",
                Ibso = ibsoid,
                FullName = "Тестов Тест Тестович",
                Passport = "12 12 123456",
                Phone = "+7 (123) 123-12-12",
                OttokReason = "Заканчивается Депозит",
                OttokDesc = "Свалить хочет",
                StopList = "ДА"
            };
            return PartialView(client);
        }

        public JsonResult GetQuestion(int qId)
        {
            var questions = new QuestionModel();
            questions.QuestionText = "Только Лохи валят!";
            questions.Answers.Add(new Answer()
            {
                AnswerId = qId,
                AnswerText = "Значит я лох...."
            });
            questions.Answers.Add(new Answer()
            {
                AnswerId = qId + 1,
                AnswerText = "Я НЕ ЛОХ! Оставюсь!"
            });
            questions.Answers.Add(new Answer()
            {
                AnswerId = qId + 2,
                AnswerText = "Ты кого лохом назвал?"
            });
            return Json(questions);
        }
    }
}
