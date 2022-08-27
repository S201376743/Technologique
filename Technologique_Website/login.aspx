<%@ Page Title="" Language="C#" MasterPageFile="~/TechnologiqueMaster.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Technologique_Website.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <!-- Breadcrumb Section Begin -->
    <section class="breadcrumb-section set-bg" data-setbg="img/keyboard-1242436.jpg">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <div class="breadcrumb__text">
                        <h2>Sign in</h2>
                        <div class="breadcrumb__option">
                            <a href="./index.aspx">Home</a>
                            <span> Sign in</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Breadcrumb Section End -->

    <!-- Login Section Begin -->
    <section class="checkout spad">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <h6><span class="icon_tag_alt"></span> Have no account? <a href="register.aspx">Click here</a> 
                    </h6>
                </div>
            </div>
            <div class="checkout__form">
                <h4>Sign in</h4>
                <form action="#">
                    <div class="row">
                        <div class="col-lg-8 col-md-6">
                            
                            <div class="checkout__input">
                                <p>Email<span>*</span></p>
                                <input type="text">
                            </div>
                            <div class="checkout__input">
                                <p>Password<span>*</span></p>
                                <input type="text">
                            </div>
                            
                                      <asp:Button ID="btnLogin" runat="server" Text="Sign in" />                
                            
                        </div>
                     
                       
                        </div>
                    </div>
                </form>
            </div>
       </section>
    <%-- login section end --%>
</asp:Content>
