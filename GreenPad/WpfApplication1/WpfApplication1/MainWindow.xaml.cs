using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using GreenPad.Entities;

namespace GreenPad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            PopulateBox();
        }

        private void PopulateBox()
        {
            var sessionFactory = CreateSessionFactory();
            using (var session = sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var project = new Project { Name = "Testing", Description = "Hello" };

                    session.SaveOrUpdate(project);

                    transaction.Commit();
                }

                using (session.BeginTransaction())
                {
                    var projects = session.CreateCriteria(typeof(Project)).List<Project>();
                    foreach (Project p in projects)
                    {
                        textBlock1.Text = p.Name + " " + p.Description;
                    }
                }
            }
        }

        private ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(c => c
                    .Server("lambda")
                    .Database("GreenPad")
                    .Username("sa")
                    .Password("*s230xhk")))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<MainWindow>())
                .BuildSessionFactory();
            //return Fluently.Configure()
            //    .Database(MsSqlConfiguration.MsSql2008.ConnectionString("Data Source=lambda;Initial Catalog=GreenPad;Persist Security Info=True;User ID=sa;Password=*s230xhk"))
            //    //.Mappings(m => m.FluentMappings.AddFromAssemblyOf<MainWindow>())
            //    .BuildSessionFactory();
        }
    }
}
