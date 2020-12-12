﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_WeSplit
{
    public class DTO_Trip
    {

        #region Fields
        private int _tripId;
        private string _tripName;

        private DateTime _tripStartDate;
        private DateTime _tripEndDate;

        private string _tripDescription;
        private double _tripBudget;
        private double _tripAverage;
        private double _tripExpenseTotal;
        private bool _tripStatus;

        private List<DTO_Place> _tripDestinationList;
        private List<DTO_Member> _tripMemberList;
        private List<DTO_Expense> _tripExpenseList;
        private List<string> _tripImages;
        #endregion

        #region Public Properties
        public int TripId { get => _tripId; set => _tripId = value; }
        public string TripName { get => _tripName; set => _tripName = value; }
        public DateTime TripStartDate { get => _tripStartDate; set => _tripStartDate = value; }
        public DateTime TripEndDate { get => _tripEndDate; set => _tripEndDate = value; }
        public string TripDescription { get => _tripDescription; set => _tripDescription = value; }
        public double TripAverage { get => _tripAverage; set => _tripAverage = value; }
        public List<DTO_Place> TripDestinationList { get => _tripDestinationList; set => _tripDestinationList = value; }
        public List<DTO_Member> TripMemberList { get => _tripMemberList; set => _tripMemberList = value; }
        public List<DTO_Expense> TripExpenseList { get => _tripExpenseList; set => _tripExpenseList = value; }
        public List<string> TripImages { get => _tripImages; set => _tripImages = value; }
        public double TripExpenseTotal { get => _tripExpenseTotal; set => _tripExpenseTotal = value; }
        public bool TripStatus { get => _tripStatus; set => _tripStatus = value; }


        #endregion

        #region Constructor
        public DTO_Trip()
        {
        }

        #endregion

    }
}
