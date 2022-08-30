<%@ Page Title="" Language="C#" MasterPageFile="~/TechnologiqueMaster.Master" AutoEventWireup="true" CodeBehind="AddEditProduct.aspx.cs" Inherits="Technologique_Website.AddEditProduct" %>
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
                            <span></span>
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
                <h4>Add Product</h4>
                <form action="#">
                    <div class="row">
                        <div class="col-lg-8 col-md-6">
                            
                            <div class="checkout__input">
                                <p>Name<span>*</span></p>
                                <input type="text" id="txtProdName" runat="server">
                            </div>
                            <div class="checkout__input">
                                <p>Description<span>*</span></p>
                                <input type="text" id="txtProdDescription" runat="server">
                            </div>
                            <div class="checkout__input">
                                <p>Stock<span>*</span></p>
                                <input type="text" id="txtProdStock" runat="server">
                            </div>
                            <div class="checkout__input">
                                <p>Price<span>*</span></p>
                                <input type="text" id="txtProdPrice" runat="server">
                            </div>
                            <div class="checkout__input">
                                <p>Image<span>*</span></p>
                                <input type="text" id="txtProdImage" runat="server">
                            </div>
                                 <asp:Button ID="btnAddProduct" runat="server" Text="Add Product" OnClick="btnAddProduct_Click" />
                        </div>
                        </div>
                    </div>
                </form>
            </div>
       </section>
    <%-- login section end --%>
</asp:Content>
