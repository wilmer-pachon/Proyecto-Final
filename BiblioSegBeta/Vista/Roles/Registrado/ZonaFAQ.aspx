<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Roles/Registrado/MasterRegistrado.master" AutoEventWireup="true" CodeFile="~/logica/Registrado/ZonaFAQ.aspx.cs" Inherits="Vista_Roles_Registrado_ZonaFAQ" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        height: 18px;
    }
    .auto-style3 {
        width: 376px;
    }
    .auto-style5 {
        width: 376px;
        height: 827px;
    }
    .auto-style6 {
        height: 827px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style2" colspan="2">
            <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="ZONA F.A.Q"></asp:Label>
            <br />
        </td>
    </tr>
    <tr>
        <td class="auto-style5">
            <asp:Label ID="Label2" runat="server" ForeColor="Red" Text="BIBLIOSEG:"></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" ForeColor="Red" Text="1)¿Que es?:"></asp:Label>
            <br />
            Somo una biblioteca en la que se encunentran las diferentes herramientas de seguridad informatica. aqui podrras ver el funcionamiento de toda aquella herramienta que busques, sus diferentes caracterisiticas y su funcionamiento.<br />
            <asp:Label ID="Label4" runat="server" ForeColor="Red" Text="Reglas de la comunidad:"></asp:Label>
            <br />
            1.No subir contenido inapropiado, enlaces porno, paginas con virus, SPAM.<br />
            2.No unsultar a los demas usuarios en los comentarios.<br />
            3.No poner enlaces con publicidad.<br />
            4.Subir contenido que su licencia permita que se pueda compartir<br />
            5.No publicar dos veces una herramienta.<br />
            6.No publicar codigos para actividades ilegales.<br />
            7.El contenido publicado ser solo confines educativos.<br />
            8.Se eliminara material morboso como cadaveres, vómitos, violaciones, sangre, heridas, enfermedades, etc.<br />
            9.No publicar contenido malicioso con el objetivo de difamar la reputación de terceros.<br />
            10.No compartir contenido de informacion privada no autorizada sobre una persona como el numero de la tarjeta de credito, numero telefonico, dirección residencial, numero de pasaporte, entre otros.<br />
            11.Los usuarios podran enviar denunciar a nuestro correo interno para que los administradores consideren&nbsp; su petición, quejas y reclamos.<br />
            12.Los moderadores pueden eliminar contenido sin advertencia alguna por incumplimientó de normas.<br />
            <asp:Label ID="Label5" runat="server" ForeColor="Red" Text="Empezar en Biblioseg:"></asp:Label>
            <br />
            Biblioseg es una biblioteca virtual en donde los usuarios comparten sus herramientas de seguridad atraves del post. Dicho contenido es comentado&nbsp; y valorado por la comunidad dándole mayor visibilidad en el index del sitio.<br />
            <asp:Label ID="Label19" runat="server" ForeColor="Red" Text="SEGURIDAD:"></asp:Label>
            <br />
            <asp:Label ID="Label21" runat="server" ForeColor="Red" Text="Bloquear usuarios:"></asp:Label>
            <br />
            El administrador y moderados estaran a cargo del bloqueo de usuarios en caso de que el contenido publicado sea inapropiado.<br />
            <asp:Label ID="Label20" runat="server" ForeColor="Red" Text="CUENTA:"></asp:Label>
            <br />
            <asp:Label ID="Label22" runat="server" ForeColor="Red" Text="Acerca de los rangos de usuarios y karma:"></asp:Label>
            <br />
            <asp:Label ID="Label23" runat="server" ForeColor="Red" Text="Karma:"></asp:Label>
            <br />
            El sistema de Karma de biblioseg funciona con un modelo de puntaje interno.<br />
            <asp:Label ID="Label24" runat="server" ForeColor="Red" Text="Rangos:"></asp:Label>
            <br />
            Troll:-10<br />
            Inexperto:10<br />
            Iniciado:20<br />
            Aprendiz:30<br />
            Amateur:40<br />
            Regular:50<br />
            Junior:60<br />
            Experto:70<br />
            Avanzado:80<br />
            Elite:90<br />
            Root:100<br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </td>
        <td class="auto-style6">
            <asp:Label ID="Label6" runat="server" ForeColor="Red" Text="REGISTRO E INICIO DE SESIÓN:"></asp:Label>
            <br />
            <asp:Label ID="Label7" runat="server" ForeColor="Red" Text="Crear cuenta:"></asp:Label>
            <br />
            Para registrase debe ingresar al sitio y clickear en la parte de izquierda en el menu principal donde dice registrar.<br />
            Alli te abrirá una pagina donde te pedirá que ingreses los datos necesarios para poder ingresar.<br />
            <asp:Label ID="Label8" runat="server" ForeColor="Red" Text="Recuperar Contraseña:"></asp:Label>
            <br />
            Para recuperar tu password/ Contraseña tienes que dirigirte a &quot;Olvido contraseña&quot; que se encuentra en la parte inferior del login.<br />
            <asp:Label ID="Label16" runat="server" ForeColor="Red" Text="MODERADORES:"></asp:Label>
            <br />
            <asp:Label ID="Label17" runat="server" ForeColor="Red" Text="¿Que es un  moderador?:"></asp:Label>
            <br />
            Un moderador son usuarios de Biblioseg con algunos permisos adicionales y se encargan de hacer cumplir las reglas de&nbsp; Comunidad de nuestro sitio ya sea filtrando. eliminando o editando la informacion que se comparte para mantener la mejor calidad posible en la experiencia de los usuarios y sus contenidos.<br />
            <asp:Label ID="Label18" runat="server" ForeColor="Red" Text="¿Puedo llegar a ser un  moderador?:"></asp:Label>
            <br />
            Si puedes llegar a ser moderador. Dependiendo de la cantidad optenida en la puntuacion en este caso mas de 80 puntos podras ser moderador.<br />
            <asp:Label ID="Label9" runat="server" ForeColor="Red" Text="POST:"></asp:Label>
            <br />
            <asp:Label ID="Label10" runat="server" ForeColor="Red" Text="Acerca del post:"></asp:Label>
            <br />
            En dicha seccion los usuarios comparten las herramientas de seguridad donde contribuyen a quienes desean conocer y aprender sobre las diferentes herramientas de seguridad que existen.<br />
            Los post agregados por los usuarios se mostraran en el index principal.<br />
            <asp:Label ID="Label11" runat="server" ForeColor="Red" Text="Agregar post:"></asp:Label>
            <br />
            Para comenzar en la creacion de un post debemos estar logeados en la cuenta y nos dirigimos al menu en donde encontraremos la opcion de agregar herramienta.<br />
            Donde podra llenar el formulario con un nombre, url del sitio, una fecha de creacion de herramienta, la descripci&#39;on de la herramienta, escoger el lenguaje, la categoria y el sistema operativo al que pertenece. Usted podra cargar una imagen para que identifique a la herramienta agregada.<br />
            <asp:Label ID="Label12" runat="server" ForeColor="Red" Text="Editar post:"></asp:Label>
            <br />
            Las herrmaientas agregadas primero seran enviadas al administrador o moderador para que este aprebe el contenido que acabas de publicar, una ves realizada la accion por parte del administrador/moderador usted tendra la opcion de editar o eliminar la herramienta agregada.<br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>


