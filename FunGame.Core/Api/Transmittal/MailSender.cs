﻿using System.Net.Mail;
using Milimoe.FunGame.Core.Library.Common.Network;
using Milimoe.FunGame.Core.Library.Constant;
using Milimoe.FunGame.Core.Library.Server;
using Milimoe.FunGame.Core.Service;

namespace Milimoe.FunGame.Core.Api.Transmittal
{
    public class MailSender : IDisposable
    {
        public Guid MailSenderID { get; }
        public SmtpClientInfo SmtpClientInfo => _SmtpClientInfo;
        public MailSendResult LastestResult => _LastestResult;
        public string ErrorMsg => _ErrorMsg;

        private readonly SmtpClientInfo _SmtpClientInfo;
        private MailSendResult _LastestResult = MailSendResult.NotSend;
        private string _ErrorMsg = "";

        public MailSender(string SenderMailAddress, string SenderName, string SenderPassword, string Host, int Port, bool OpenSSL)
        {
            MailSenderID = Guid.NewGuid();
            _SmtpClientInfo = new SmtpClientInfo(SenderMailAddress, SenderName, SenderPassword, Host, Port, OpenSSL);
        }

        public MailObject CreateMail(string Subject, string Body, MailPriority Priority, bool HTML, string[] ToList, string[] CCList, string[] BCCList)
        {
            return new MailObject(this, Subject, Body, Priority, HTML, ToList, CCList, BCCList);
        }

        public MailSendResult Send(MailObject Mail)
        {
            _LastestResult = MailManager.Send(this, Mail, out _ErrorMsg);
            return _LastestResult;
        }

        public bool Dispose()
        {
            return MailManager.Dispose(this);
        }

        void IDisposable.Dispose()
        {
            MailManager.Dispose(this);
            GC.SuppressFinalize(this);
        }
    }
}
