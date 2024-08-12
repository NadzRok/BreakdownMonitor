import { AddIcon } from "@chakra-ui/icons";
import { Box, Button, Flex, Heading, Table, TableContainer, Tbody, Td, Th, Thead, Tr } from "@chakra-ui/react";
import axios from "axios";
import { BASE_URL } from "./constant";
import { useEffect, useState } from "react";
import { Breakdown } from "./types/breakdown";

function App() {
    const [data, setData] = useState<Breakdown[]>([]);
    const [isLoading, setIsloading] = useState<boolean>(false);
    useEffect(() => {
        fetchdata();
    },[])
    const fetchdata = () => {
        setIsloading(true);
        axios.get(BASE_URL +"breakdowns").then((response) => {
            setData(response.data);
        }).catch((error) => {
            console.log(error);
        }).finally(() => {
            setIsloading(false);
        })
    }

    return (
        <Box shadow={'md'} rounded={'md'} m={32}>
            <Flex px="5" justifyContent={'space-between'} mb={5} alignItems={'center'}>
                <Heading>
                    Breakdown List
                </Heading>
                <Button colorScheme='blue' leftIcon={<AddIcon/>}>
                    Add Beakdown
                </Button>
            </Flex>
            <TableContainer>
                <Table variant='striped'>
                    <Thead>
                        <Tr>
                            <Th>Breakdown Reference</Th>
                            <Th>Company Name</Th>
                            <Th>Driver Name</Th>
                            <Th>Registration Number</Th>
                            <Th>Breakdown Date</Th>
                        </Tr>
                    </Thead>
                    <Tbody >
                        {
                            data.map((breakdown: Breakdown) => (
                                <Tr key={breakdown.id}>
                                    <Td>{breakdown.BreakdownReference}</Td>
                                    <Td>{breakdown.CompanyName}</Td>
                                    <Td>{breakdown.DriverName}</Td>
                                    <Td>{breakdown.RegistrationNumber}</Td>
                                    <Td>{breakdown.BreakdownDate}</Td>
                                </Tr>
                            ))
                        }
                    </Tbody>
                </Table>
            </TableContainer>
            {
                data.length == 0 && <Heading>No Data</Heading>
            }
        </Box>
    );
    
}

export default App;