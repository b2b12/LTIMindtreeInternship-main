select name from building_type where connection_type_id=(select id from meter where meter_number='SG824012');
