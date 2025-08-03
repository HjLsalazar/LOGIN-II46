<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="center-page" style="width:100%;">
        <div class="card shadow-lg p-4" style="max-width:400px;width:100%;">
            <div class="card-body">
                <h2 class="h4 mb-3 text-center">Iniciar Sesion</h2>
                <div class="form-floating">
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" TextMode="Email" placeholder="Email"></asp:TextBox>
                    <label for="MainContent_txtEmail">Email</label>
                </div>
                <div class="form-floating">
                    <asp:TextBox ID="txtPass" runat="server" CssClass="form-control" TextMode="Password" placeholder="Contraseña"></asp:TextBox>
                    <label for="MainContent_txtPass">Contraseña</label>
                </div>
                <div class="form-check mb-3">
                    <asp:CheckBox ID="chkRecordar" runat="server" CssClass="form-check-input" />
                    <label class="form-check-label" for="MainContent_chkRecordar">Recordar</label>
                </div>
                <asp:Button CssClass="btn btn-primary w-100 py-2" ID="btnAcceder" runat="server" Text="Acceder" />
                <a href="Registro.aspx">¿Primera vez que ingresa?</a>
            </div>
        </div>
    </div>
</asp:Content>


           
