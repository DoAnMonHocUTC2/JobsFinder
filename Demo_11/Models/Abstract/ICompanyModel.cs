﻿using Data;

namespace Demo_1.Models
{
    public interface ICompanyModel
    {
        cong_ty CheckLogin(string phoneNumber, string password);
        bool CheckContact(string phoneNumber, string email);
    }
}