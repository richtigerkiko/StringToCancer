function StringToCancer([string] $notCancerYet)
{
    $i = 0;
    $cancerString
    foreach ($c in $notCancerYet.ToCharArray())
    {
        if($c -eq " ") {$i++;}
        if ($i % 2 -eq 0)
        {
            $char = $char.ToString().ToUpper();
            $cancerString = $cancerString + $c;
        }
        else
        {
            $char = $char.ToString().ToLower();
            $cancerString = $cancerString + $c;
        }
        $i++;
    }
    return $cancerString;
}

StringToCancer(Read-Host "Insert uncancerous string") | Set-Clipboard