﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;

namespace Supermarket_mvp.Presenters
{
    internal class PayModePresenter
    {
        private IPayModeView view;
        private PayModeRepository repository;
        private BindingSource payModeBindingSource;
        private IEnumerable<PayModeModel> payModelist;

        public PayModePresenter(IPayModeView view, PayModeRepository repository)
        {
            this.payModeBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchPayMode;
            this.view.AddNewEvent += AddNewPayMode;
            this.view.EditEvent += LoadSelectPayModeToEdit;
            this.view.DeleteEvent += DeleteSelectedPayMode;
            this.view.SaveEvent += SavePayMode;
            this.view.CancelEvent += CancelAction;
            this.view.SetPayModelistBildingSource(payModeBindingSource);
            
            loadAllPayModeList();
            this.view.Show();
        }

        private void SearchPayMode(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                payModelist = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                payModelist = repository.GetAll();
            }
            payModeBindingSource.DataSource = payModelist;
        }

        private void AddNewPayMode(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void loadAllPayModeList()
        {
            payModelist = repository.GetAll();
            payModeBindingSource.DataSource = payModelist;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SavePayMode(object? sender, EventArgs e)
        {
            
        }

        private void DeleteSelectedPayMode(object? sender, EventArgs e)
        { 
            throw new NotImplementedException();
        }

        private void LoadSelectPayModeToEdit(object? sender, EventArgs e)
        { 
            throw new NotImplementedException(); 
        }


    }
}
