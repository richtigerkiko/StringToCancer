function StringToCancer([string] $notCancerYet)
{
    $i = 0;
    $cancerString
    foreach ($char in $notCancerYet.ToCharArray())
    {
        if($char -eq " ")$i++;

        if ($i % 2 -eq 0)
        {
            $char = $char.ToString().ToUpper();
            $cancerString = $cancerString + $char;
        }
        else
        {
            $char = $char.ToString().ToLower();
            $cancerString = $cancerString + $char;
        }
        $i++;
    }
    return $cancerString;
}

