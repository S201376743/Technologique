<%@ Page Title="" Language="C#" MasterPageFile="~/TechnologiqueMaster.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="Technologique_Website.register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <!-- Breadcrumb Section Begin -->
    <section class="breadcrumb-section set-bg" data-setbg="img/keyboard-1242436.jpg">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <div class="breadcrumb__text">
                        <h2>Register</h2>
                        <div class="breadcrumb__option">
                            <a href="./index.aspx">Home</a>
                            <span>Register</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Breadcrumb Section End -->

    <!-- Register Section Begin -->
    <section class="checkout spad">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <h6><span class="icon_tag_alt"></span> Have an account? <a href="login.aspx">Click here</a> 
                    </h6>
                </div>
            </div>
            <div class="checkout__form">
                <h4>Account Details</h4>
                <form action="#">
                    <div class="row">
                        <div class="col-lg-8 col-md-6">
                            <div class="row">
                                <div class="col-lg-6">
                                    <div class="checkout__input">
                                        <p>First Name<span>*</span></p>
                                        <input type="text" id="txtName" runat="server">
                                    </div>
                                </div>
                                <div class="col-lg-6">
                                    <div class="checkout__input">
                                        <p>Surname<span>*</span></p>
                                        <input type="text" id="txtSurname" runat="server">
                                    </div>
                                </div>
                            </div>
                            <div class="checkout__input">
                                <p>Email<span>*</span></p>
                                <input type="text" id="txtEmail" runat="server">
                            </div>
                            <div class="checkout__input">
                                <p>Address<span>*</span></p>
                                <input type="text" placeholder="Street Address" class="checkout__input__add" id="txtStreetAddress" runat="server">
                                <input type="text" placeholder="Complex / Building (optinal)" id="txtApartment" runat="server">
                            </div>
                            <div class="checkout__input">
                                <p>Town/City<span>*</span></p>
                                <input type="text" id="txtTown" runat="server">
                            </div>
                            <div class="checkout__input">
                                <p>Province<span>*</span></p>
                                <input type="text" id="txtProvince" runat="server">
                            </div>
                            <div class="checkout__input">
                                <p>Postal Code<span>*</span></p>
                                <input type="text" id="txtPostalCode" runat="server">
                            </div>
                            <div class="checkout__input">
                                <p>Password<span>*</span></p>
                                <input type="text" id="txtPassword" runat="server">
                            </div>
                            <div class="checkout__input">
                                <p>Confirm Password<span>*</span></p>
                                <input type="text" id="txtConfirmPassword" runat="server">
                            </div>
                          
                             <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
                        </div>
                     
                       
                        </div>
                    </div>
                </form>
            </div>
       </section>
    <%-- Register section end --%>
</asp:Content>
