// See https://aka.ms/new-console-template for more information
using MVC.Controller;
using MVC.Model;
using MVC.View;

IBpmModel model = new BpmModel();
IBpmController bpmController = new BpmController(model);
IBpmView bpmView = bpmController.ExposeView();
bpmView.Start();
Thread.Sleep(10000);
bpmView.Display();
bpmView.SetBpm(100);
Thread.Sleep(10000);
bpmView.Start();
bpmView.DecrementBpmButton();
bpmView.Stop();
bpmView.Stop();

