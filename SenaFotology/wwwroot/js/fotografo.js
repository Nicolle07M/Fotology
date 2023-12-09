<script>
    $(document).ready(function () {
        $("#fotografo-link").click(function (e) {
            e.preventDefault(); // Evita que el enlace haga la acción predeterminada (navegar a la URL)

            // Redirige manualmente a la acción IniciarSesionFotografo
            window.location.href = $(this).attr("href");
        });
        });
</script>