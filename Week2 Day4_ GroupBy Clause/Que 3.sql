select batch,count(*) as female_alumni_count
from profile
where gender='Female'
group by batch
