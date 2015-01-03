﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using u2flib.Data.Messages;

namespace UnitTests.Messages
{
    [TestClass]
    public class RawRegisterResponseUnitTests
    {
        [TestMethod]
        public void RawRegisterResponse_FromBase64()
        {
            RegisterResponse registerResponse = new RegisterResponse(TestConts.REGISTRATION_RESPONSE_DATA_BASE64, TestConts.CLIENT_DATA_REGISTER_BASE64);
            RawRegisterResponse rawAuthenticateResponse = RawRegisterResponse.FromBase64(registerResponse.RegistrationData);

            Assert.IsNotNull(rawAuthenticateResponse);
            Assert.IsNotNull(rawAuthenticateResponse.CreateDevice());
            Assert.IsTrue(rawAuthenticateResponse.GetHashCode() != 0);
        }

        [TestMethod]
        public void RawRegisterResponse_Equals()
        {
            RegisterResponse registerResponse = new RegisterResponse(TestConts.REGISTRATION_RESPONSE_DATA_BASE64, TestConts.CLIENT_DATA_REGISTER_BASE64);
            RawRegisterResponse rawAuthenticateResponse1 = RawRegisterResponse.FromBase64(registerResponse.RegistrationData);
            RawRegisterResponse rawAuthenticateResponse = RawRegisterResponse.FromBase64(registerResponse.RegistrationData);

            Assert.IsTrue(rawAuthenticateResponse.Equals(rawAuthenticateResponse1));
        }
    }
}