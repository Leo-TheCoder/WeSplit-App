﻿using DAO_WeSplit;
using DTO_WeSplit;
using System;
using System.Collections.Generic;
using System.Data;

namespace BUS_WeSplit
{
    public class BUS_Member
    {
        private static BUS_Member _instance = new BUS_Member();
        public static BUS_Member Instance
        {
            get
            {
                return _instance;
            }
        }

        public List<DTO_Member> GetAllMembers()
        {
            DataTable data = new DataTable();
            List<DTO_Member> result = new List<DTO_Member>();

            data = DAO_Member.Instance.GetAllMembers();

            foreach (DataRow row in data.Rows)
            {
                int id = int.Parse(row["MemberID"].ToString());
                string name = row["MemberName"].ToString();
                DateTime dob = (DateTime)row["MemberDOB"];
                bool sex = (bool)row["MemberSex"];
                string avatar = row["MemberAvatar"].ToString();

                DTO_Member tmpMember = new DTO_Member(id, name, dob, sex, avatar);
                
                string dir = System.AppDomain.CurrentDomain.BaseDirectory;
                dir += $@"resources\avatars\{tmpMember.MemberID}\";
                dir += avatar;

                tmpMember.MemberAvatar = dir;

                result.Add(tmpMember);
            }

            return result;
        }

        public DTO_Member GetMember(int id)
        {
            DataRow row = DAO_Member.Instance.GetMember(id);
            if (row!=null)
            {
                string name = row["MemberName"].ToString();
                DateTime dob = (DateTime)row["MemberDOB"];
                bool sex = (bool)row["MemberSex"];
                string avatar = row["MemberAvatar"].ToString();
                DTO_Member result = new DTO_Member(id, name, dob, sex, avatar);
                return result;
            }
            else 
                return null;
        }

        public int GetAmountOfMember()
        {
            int result;
            DataTable data = DAO_Member.Instance.GetAmountOfMember();

            DataRow row = data.Rows[0];

            result = int.Parse(row["Amount"].ToString());

            return result;
        }

        public int GetAmountOfMember(int tripID)
        {
            int result;
            DataTable data = DAO_Member.Instance.GetAmountOfMember(tripID);

            DataRow row = data.Rows[0];

            result = int.Parse(row["Amount"].ToString());

            return result;
        }

        public List<Tuple<DTO_Member, double, double>> GetMembersOfTrip(int tripID)
        {
            DataTable data = new DataTable();
            List<Tuple<DTO_Member, double, double>> result = new List<Tuple<DTO_Member, double, double>>();

            data = DAO_Member.Instance.GetMembersOfTrip(tripID);

            foreach (DataRow row in data.Rows)
            {
                int id = int.Parse(row["MemberID"].ToString());
                string name = row["MemberName"].ToString();
                DateTime dob = (DateTime)row["MemberDOB"];
                bool sex = (bool)row["MemberSex"];
                string avatar = row["MemberAvatar"].ToString();
                string tmpString;
                tmpString = row["Paid"].ToString();
                double paid = 0;
                if (tmpString != "")
                {
                    paid = double.Parse(tmpString);
                }

                tmpString = row["Change"].ToString();
                double change = 0;
                if (tmpString != "")
                {
                    change = double.Parse(tmpString);
                }

                DTO_Member tmpMember = new DTO_Member(id, name, dob, sex, avatar);
                Tuple<DTO_Member, double, double> tmpTuple = new Tuple<DTO_Member, double, double>(tmpMember, paid, change);
                result.Add(tmpTuple);
            }

            return result;
        }

        public List<DTO_Member> GetMembersPerTrip(int tripId)
        {
            List<DTO_Member> result = new List<DTO_Member>();
            DataTable data = DAO_Member.Instance.GetMembersOfTrip(tripId);
            foreach (DataRow row in data.Rows)
            {
                int id = int.Parse(row["MemberID"].ToString());
                string name = row["MemberName"].ToString();
                DateTime dob = (DateTime)row["MemberDOB"];
                bool sex = (bool)row["MemberSex"];
                string avatar = row["MemberAvatar"].ToString();

                DTO_Member tmpMember = new DTO_Member(id, name, dob, sex, avatar);
                result.Add(tmpMember);
            }
            return result;
        }

        public List<DTO_Member> GetAvailableMembers(int tripID)
        {
            List<DTO_Member> result = new List<DTO_Member>();
            DataTable data = new DataTable();

            data = DAO_Member.Instance.GetAvailableMembers(tripID);

            foreach (DataRow row in data.Rows)
            {
                int id = int.Parse(row["MemberID"].ToString());
                string name = row["MemberName"].ToString();
                DateTime dob = (DateTime)row["MemberDOB"];
                bool sex = (bool)row["MemberSex"];
                string avatar = row["MemberAvatar"].ToString();

                DTO_Member tmpMember = new DTO_Member(id, name, dob, sex, avatar);
                result.Add(tmpMember);
            }

            return result;
        }

        public void AddMemberPerTrip(int memberID, int tripId)
        {
            DAO_Member.Instance.AddMemberPerTrip(memberID, tripId);
        }

        public void DeleteMemberPerTrip(int tripId, int memberId)
        {
            DAO_Member.Instance.DeleteMemberPerTrip(tripId, memberId);
        }

        public void AddMember(DTO_Member member)
        {
            DAO_Member.Instance.AddMember(member);
        }

    }
}
