select batch, count(*) as profile_count
from profile
group by batch 
