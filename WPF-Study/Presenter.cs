using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Study
{
    class Presenter
    {
        private Abstractions.IModel model;
        private Abstractions.IView view;


        public Presenter(Abstractions.IModel model, Abstractions.IView view)
        {
            this.model = model;
            this.view = view;

            this.view.OpenFile += Show;
            this.view.TextBox += Start();
            
        }
        //void Save(object sender, EventArgs e)
        //{
        //    model.SaveIn(view.TextBox);
        //}
        //void Result(object sender, EventArgs e)
        //{

        //    view.ClearText();
        //    view.GetRes(model.Operation());
        //}

        string Start()
        {
            return model.ReadFile(view.FileName);
        }

        void Show(object sender, EventArgs e)
        {
            view.GetRes(model.ReadFile(view.FileName));
        }
    }
}
