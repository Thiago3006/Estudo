<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <link rel="stylesheet" href="style.css"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    
      
    

</head>
<body>
    <div2>
        <form  method = "get" action="conclusao.php">
             
            <?php
                $n = $_GET["nom"];
                $c = $_GET["cit"];
                $p = $_GET["cor"];
                $s = $_GET["sexo"];
                
                echo "<strong>VERIFIQUE OS DADOS POR FAVOR</strong><br/>";
                
                echo "<br/>Nome completo: <font color = $p> <strong> $n </strong> </font><br/>";
                echo "Sexo: <font color = $p><strong>$s</strong></font><br/>";
                echo "Cidade: <font color = $p><strong>$c</strong></font> <br/>";        
                              
            ?>
            
            <p><strong>Escolha uma cor e confirme!</strong></p>
            <input type = "color" name= "cor2" list= "cor">
            <button> Confirmar</button>
            
        </form>
    </div2>
</body>
</html>