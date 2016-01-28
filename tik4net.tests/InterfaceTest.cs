﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using tik4net.Objects;
using tik4net.Objects.Interface;

namespace tik4net.tests
{
    [TestClass]
    public class InterfaceTest: TestBase
    {
        [TestMethod]
        public void ListAllInterfaceWillNotFail()
        {
            var list = Connection.LoadAll<Interface>();
            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void ListAllWirelessInterfaceWillNotFail()
        {
            var list = Connection.LoadAll<InterfaceWireless>();
            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void ListAllWirelessRegistrationsWillNotFail()
        {
            var list = Connection.LoadAll<InterfaceWireless.WirelessRegistrationTable>();
            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void ListAllEthernetWillNotFail()
        {
            var list = Connection.LoadAll<InterfaceEthernet>();
            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void FilteredUntypedListOfInterfacesWillNotFail()
        {
            var cmd = Connection.CreateCommandAndParameters(@"/interface/print
                            ?type=ether
                            ?type=wlan
                            ?#|");
            var list = cmd.ExecuteList();

            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void FilteredTypedListOfInterfacesWillNotFail()
        {
            var cmd = Connection.CreateCommandAndParameters(@"/interface/print
                            ?type=ether
                            ?type=wlan
                            ?#|");
            var list = cmd.LoadList<Interface>();

            Assert.IsNotNull(list);
        }

    }
}
